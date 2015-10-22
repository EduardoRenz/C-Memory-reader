using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Rebot
{
    class Tasker
    {
        // VARIAVEIS
        public bool isRodando { get; set; }
        private Process[] processos;
        public List<string> memoria = new List<string>(); // Lista posições da memoria e eus valores, do processo
        public string currentPosition;

        // REQUIRED CONSTS ===================================================================================================================

        const int PROCESS_QUERY_INFORMATION = 0x0400;
        const int MEM_COMMIT = 0x00001000;
        const int PAGE_READWRITE = 0x04;
        const int PROCESS_WM_READ = 0x0010;
        const int PROCESS_VM_WRITE = 0x0020;
        const int PROCESS_VM_OPERATION = 0x0008;

        // REQUIRED STRUCTS

        public struct MEMORY_BASIC_INFORMATION
        {
            public int BaseAddress;
            public int AllocationBase;
            public int AllocationProtect;
            public int RegionSize;
            public int State;
            public int Protect;
            public int lType;
        }

        public struct SYSTEM_INFO
        {
            public ushort processorArchitecture;
            ushort reserved;
            public uint pageSize;
            public IntPtr minimumApplicationAddress;
            public IntPtr maximumApplicationAddress;
            public IntPtr activeProcessorMask;
            public uint numberOfProcessors;
            public uint processorType;
            public uint allocationGranularity;
            public ushort processorLevel;
            public ushort processorRevision;
        }


        // REQUIRED METHODS

        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(int hProcess, int lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesRead);

        [DllImport("kernel32.dll")]
        static extern void GetSystemInfo(out SYSTEM_INFO lpSystemInfo);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern int VirtualQueryEx(IntPtr hProcess, IntPtr lpAddress, out MEMORY_BASIC_INFORMATION lpBuffer, uint dwLength);


        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool WriteProcessMemory(int hProcess, int lpBaseAddress,
          byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesWritten);

        // ==================================================================================================================================================

        public Tasker()
        {
           processos = Process.GetProcesses();
            isRodando = true;
        }

        // ------------------------------------------ LISTA TODOS OS PROCESSOS -----------------------------------------------------------
        public List<string> listarprocesos() 
        {
            List<string> lista = new List<string>();  //Lista de processos
            foreach (Process theprocess in processos)
            {
              lista.Add (theprocess.Id + " " + theprocess.ProcessName + "");
            //  Console.WriteLine("Process: {0} ID: {1}", theprocess.ProcessName, theprocess.Id);
            }
            return lista;
        }
        // ---------------------------------------------------------------------------------------------------------------------------------
        // ------------------------------------------ BUSCA PROCESSO BASEADO EM STRING-------------------------------------------------------
        public List<string> procura_processo(string busca)
        {
            List<string> resultado = new List<string>(); // somente lista de resultados
            List<string> lista = listarprocesos();  //Lista de processos
            resultado = lista.FindAll(delegate (string s) { return s.Contains(busca); });
            Process[] processo = Process.GetProcessesByName(busca);
            foreach (Process theprocess in processo)
            {
                resultado.Add(theprocess.Id + " " + theprocess.ProcessName + "");
            }
            return resultado;
        }
        // ---------------------------------------------------------------------------------------------------------------------------------
        // ----------------------------------------------------- LEITURA DE PROCESSO -------------------------------------------------------
        public void lerProcesso(int idProcesso,BackgroundWorker worker,string pesquisa)
        {
            byte[] pesquisabytes = Encoding.ASCII.GetBytes(pesquisa);
            var tamanhoStr = pesquisabytes.Length;
            List<string> resultado = new List<string>();
            // getting minimum & maximum address
            SYSTEM_INFO sys_info = new SYSTEM_INFO();
            GetSystemInfo(out sys_info);
            IntPtr proc_min_address = sys_info.minimumApplicationAddress;
            IntPtr proc_max_address = sys_info.maximumApplicationAddress;
            // saving the values as long ints so I won't have to do a lot of casts later
            long proc_min_address_l = (long)proc_min_address;
            long proc_max_address_l = (long)proc_max_address;
            // encontra o processo rodando
            Process process = Process.GetProcessById(idProcesso);
            // abre o processo com o nivel de acesso desejado
            IntPtr processHandle = OpenProcess(PROCESS_QUERY_INFORMATION | PROCESS_WM_READ, false, process.Id);
            StreamWriter sw = new StreamWriter("C:/Users/Eduardo/Desktop/dump.txt");
            // this will store any information we get from VirtualQueryEx()
            MEMORY_BASIC_INFORMATION mem_basic_info = new MEMORY_BASIC_INFORMATION();
            int bytesRead = 0;  // number of bytes read with ReadProcessMemory

                while (proc_min_address_l < proc_max_address_l)
                {
                    // 28 = sizeof(MEMORY_BASIC_INFORMATION)
                    VirtualQueryEx(processHandle, proc_min_address, out mem_basic_info, 28);
                    // if this memory chunk is accessible
                    if (mem_basic_info.Protect == PAGE_READWRITE && mem_basic_info.State == MEM_COMMIT)
                    {
                        byte[] buffer = new byte[mem_basic_info.RegionSize];
                        // read everything in the buffer above
                        ReadProcessMemory((int)processHandle, mem_basic_info.BaseAddress, buffer, mem_basic_info.RegionSize, ref bytesRead);
                        // ************************************************  AQUI FAZ A LEITURA DOS ENDERECOS *****************************************
                        for (int i = 0; i < mem_basic_info.RegionSize; i++)
                        {
                        var vetStrBusca = 0;
                        // COLOCANO AS INFORMAÇÔES EM UM ARQUIVO DE TEXTO ======
                        sw.WriteLine("0x{0} : {1}", (mem_basic_info.BaseAddress + i).ToString("X"), (char)buffer[i]);  
                        // =======================================================

                        for (; vetStrBusca < tamanhoStr; vetStrBusca++)
                        {
                            if (pesquisabytes[vetStrBusca] != buffer[i + vetStrBusca]) break;
                        }

                        if (vetStrBusca == tamanhoStr)
                        {
                            ler((mem_basic_info.BaseAddress + i), pesquisa, idProcesso);
                            // Console.WriteLine("0x{0} : {1}", (mem_basic_info.BaseAddress + i).ToString("X"), (char)buffer[i]);
                            memoria.Add((mem_basic_info.BaseAddress + i).ToString("X") + " : " + pesquisa);
                           // escrever((mem_basic_info.BaseAddress + i), "It", process.Id);
                        }
                        if (isRodando == false)
                            {
                                worker.CancelAsync();
                                break;
                            }
                        }
                   

                }
                    // move to the next memory chunk
                    proc_min_address_l += mem_basic_info.RegionSize;
                    proc_min_address = new IntPtr(proc_min_address_l);
                    if (!isRodando)
                    {
                        worker.CancelAsync();
                        break;
                    }
                }
            sw.Close();

        }

        public void ler(int endereco, string valor, int idProcesso)
        {
            Process process = Process.GetProcessById(idProcesso);
            IntPtr processHandle = OpenProcess(PROCESS_WM_READ, false, process.Id);

            int bytesRead = 0;
            byte[] buffer = new byte[valor.Length]; //'Hello World!' takes 12*2 bytes because of Unicode 


            // 0x0046A3B8 is the address where I found the string, replace it with what you found
            ReadProcessMemory((int)processHandle, endereco, buffer, buffer.Length, ref bytesRead);

            Console.WriteLine(Encoding.ASCII.GetString(buffer) +  " (" + bytesRead.ToString() + "bytes) em" + endereco.ToString("X"));
        }
        public void escrever(int endereco,string valor, int idProcesso)
        {
            Process process = Process.GetProcessById(idProcesso);
            IntPtr processHandle = OpenProcess(0x1F0FFF, false, process.Id);

            int bytesWritten = 0;
            byte[] buffer = new byte[valor.Length];
              buffer =  Encoding.Unicode.GetBytes(valor+"\0");
            // '\0' marks the end of string

            // replace 0x0046A3B8 with your address

                WriteProcessMemory((int)processHandle,endereco, buffer, buffer.Length, ref bytesWritten);

            Console.Write("escrito em " + endereco);

        }

    }
}
