using System.Collections.Generic;
using IronPython.Hosting;
using IronPython.Runtime;
using IronPython;
using Microsoft.Scripting.Hosting;
using Microsoft.Scripting;
using System;
using System.IO;
using System.Diagnostics;
using System.Linq;

namespace ChecaLista
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var lista = new List<string>();
            lista.AddRange(new List<string> { "2021-04-02T10:00,USDJPY,PUT,M5","2021-04-02T11:00,USDJPY,CALL,M5"
                ,"2021-04-02T11:20,USDJPY,PUT,M5","2021-04-02T09:00,USDJPY,CALL,M15"});
            string listValues = String.Join(",", lista.Select(value => String.Format("\"{0}\"", value)).ToArray());
            var lista2 = lista.ToArray();
            int a = 2;
            int b = 2;

            Process p = new Process(); // create process (i.e., the python program
            p.StartInfo.FileName = "/Library/Frameworks/Python.framework/Versions/3.9/bin/python3";
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

            //var lista = new List<string>();
            //lista.AddRange(new List<string> { "2021-04-02 10:00,USDJPY,PUT,M5","2021-04-02 11:00,USDJPY,CALL,M5"
            //    ,"2021-04-02 11:20,USDJPY,PUT,M5","2021-04-02 09:00,USDJPY,CALL,M15"});
            //ScriptEngine engine = Python.CreateEngine();
            //ScriptScope scope = engine.CreateScope();
            //engine.ExecuteFile("bot_.py", scope);
            //dynamic testFunction = scope.GetVariable("get_CandleResults");
            //var result = testFunction(lista);

            #region FUNCIONOU 
            //// the python program as a string. Note '@' which allow us to have a multiline string
            ////String prg = @"import sys
            ////x = int(sys.argv[1])
            ////y = int(sys.argv[2])
            ////print x+y";
            ////StreamWriter sw = new StreamWriter("test_.py");
            ////sw.Write(prg); // write this program to a file
            ////sw.Close();

            //int a = 2;
            //int b = 2;

            //Process p = new Process(); // create process (i.e., the python program
            //p.StartInfo.FileName = "/Library/Frameworks/Python.framework/Versions/3.9/bin/python3";
            //p.StartInfo.RedirectStandardOutput = true;
            //p.StartInfo.UseShellExecute = false; // make sure we can read the output from stdout
            //p.StartInfo.Arguments = "test_.py " + a + " " + b; // start the python program with two parameters
            //p.Start(); // start the process (the python program)
            //StreamReader s = p.StandardOutput;
            //String output = s.ReadToEnd();
            //string[] r = output.Split(new char[] { ' ' }); // get the parameter
            //Console.WriteLine(r[0]);
            //p.WaitForExit();

            //Console.ReadLine(); // wait for a key press
            #endregion
        }
        //public static async System.Threading.Tasks.Task Main(string[] args)
        //{
        //    var client = new IqOptionApi("emailaddress", "password");

        //    //begin connect
        //    if (await client.ConnectAsync())
        //    {

        //        //get user profile
        //        var profile = await client.GetProfileAsync();

        //    }
        //    //var client = new IqOptionApi("emailaddress", "password");
        //    IqOptionClient IqClientApi = new IqOptionClient("marcelobertinatto@hotmail.com","Fh006131__");
        //    var connected = await IqClientApi.ConnectAsync();

        //    //begin connect
        //    if (connected)
        //    {

        //        //get user profile
        //        var profile = await IqClientApi.GetProfileAsync();

        //        //// open order EurUsd in smallest period (1min)
        //        //var exp = DateTime.Now.AddMinutes(1);
        //        //var buyResult = await client.BuyAsync(ActivePair.EURUSD, 1, OrderDirection.Call, exp);

        //        //// get candles data
        //        //var candles = await client.GetCandlesAsync(ActivePair.EURUSD, TimeFrame.Min1, 100, DateTimeOffset.Now);
        //        //_logger.LogInformation($"CandleCollections received {candles.Count}");


        //        //// subscribe to pair to get real-time data for tf1min and tf5min
        //        //var streamMin1 = await client.SubscribeRealtimeDataAsync(ActivePair.EURUSD, TimeFrame.Min1);
        //        //var streamMin5 = await client.SubscribeRealtimeDataAsync(ActivePair.EURUSD, TimeFrame.Min5);

        //        //streamMin5.Merge(streamMin1)
        //        //    .Subscribe(candleInfo => {
        //        //        _logger.LogInformation($"Now {ActivePair.EURUSD} {candleInfo.TimeFrame} : Bid={candleInfo.Bid}\t Ask={candleInfo.Ask}\t");
        //        //    });

        //        //// after this line no-more realtime data for min5 print on console
        //        //await client.UnSubscribeRealtimeData(ActivePair.EURUSD, TimeFrame.Min5);

        //    }

        //    Console.WriteLine("Hello World!");
        //}
    }
}
