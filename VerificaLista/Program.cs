using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace VerificaLista
{
    class Program
    {
        static void Main(string[] args)
        {
            var lista = new List<string>();
            lista.AddRange(new List<string> { "2021-04-02T10:00,USDJPY,PUT,M5","2021-04-02T11:00,USDJPY,CALL,M5"
                ,"2021-04-02T11:20,USDJPY,PUT,M5","2021-04-02T09:00,USDJPY,CALL,M15"});
            string listValues = String.Join(",", lista.Select(value => String.Format("\"{0}\"", value)).ToArray());
            var lista2 = lista.ToArray();
            int a = 2;
            int b = 2;

            Process p = new Process(); // create process (i.e., the python program
            //p.StartInfo.FileName = "/Library/Frameworks/Python.framework/Versions/3.9/bin/python3";
            p.StartInfo.FileName = "python.exe";
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.UseShellExecute = false; // make sure we can read the output from stdout
            //p.StartInfo.Arguments = "bot_.py " + a + " " + b; // start the python program with two parameters
            p.StartInfo.Arguments = "bot2.py " + listValues; // start the python program with two parameters
            p.Start(); // start the process (the python program)
            StreamReader s = p.StandardOutput;
            String output = s.ReadToEnd();
            string[] r = output.Split(new char[] { ' ' }); // get the parameter
            for (int i = 0; i < r.Length; i++)
            {
                Console.WriteLine(r[i]);
            }
            p.WaitForExit();

            Console.ReadLine(); // wait for a key press
        }
    }
}
