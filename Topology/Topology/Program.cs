using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Topology
{
    class Program
    {
        static void Main(string[] args)
        {
            String line;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                Console.WriteLine("Introduce the directory of the topology's file: ");
                String Directory = Console.ReadLine();
                StreamReader sr = new StreamReader(Directory);

                int cont = 0;
                List<string> variables = new List<string>();


                //Read the first line of text
                line = sr.ReadLine();

                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the lie to console window
                    //Console.WriteLine(line);
                    variables.Add(line);
                    //Read the next line
                    line = sr.ReadLine();

                    cont++;
                }

                foreach (string variable in variables)
                {
                    Console.WriteLine(variable);
                }

                //We have to separate variables
                int Nnodes = Convert.ToInt32(variables[0]);
                char[] delimiterChars = { ' ', '[', ']' };
                //List<string> IDs = new List<string>();
                string[] IDs = new string[10];
                string[] Connections = new string[10];
                string[] Delays = new string[10];
                string[] routesConnections = new string[10];


                Console.WriteLine();

                for (int i = 0; i < variables.Capacity - 1; i++)
                {
                    string var = variables[i + 1]; //Correspondent line
                    string[] var2 = var.Split(delimiterChars); //Splitting
                    IDs[i] = var2[0];
                    Connections[i] = var2[1];
                    Delays[i] = var2[2];
                    routesConnections[i] = var2[4];

                    Console.WriteLine("<{0}>", Nnodes);
                    Console.WriteLine("<{0}><{1}><{2}>[{3}]<{4}>", IDs[i], Connections[i], Delays[i], routesConnections[i], Connections[i]);

                }

                Console.WriteLine();
                Console.WriteLine("IDs: ");
                foreach (string ID in IDs)
                {
                    Console.Write(ID);
                    Console.Write(" ");
                }

                Console.WriteLine();
                Console.WriteLine("Connections: ");
                foreach (string Connection in Connections)
                {
                    Console.Write(Connection);
                    Console.Write(" ");
                }

                Console.WriteLine();
                Console.WriteLine("Delays: ");
                foreach (string Delay in Delays)
                {
                    Console.Write(Delay);
                    Console.Write(" ");
                }

                Console.WriteLine();
                Console.WriteLine("routeConnections: ");
                foreach (string routeConnection in routesConnections)
                {
                    Console.Write(routeConnection);
                    Console.Write(" ");
                }

                Console.WriteLine();

                List<string> Neighbours1 = new List<string>();
                List<string> Neighbours2 = new List<string>();
                List<string> Neighbours3 = new List<string>();
                List<string> Neighbours4 = new List<string>();
                List<string> Neighbours5 = new List<string>();
                List<string> Neighbours6 = new List<string>();


                for (int i = 0; i < Nnodes; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine("Node {0} Neighbours?: ", i + 1);

                    if (i == 0)
                    {
                        string string1 = Console.ReadLine();
                        string[] str1 = string1.Split(' ', ',');
                        for (int j = 0; j < str1.Length; j++) { Neighbours1.Add(str1[j]); }

                    }

                    if (i == 1)
                    {
                        string string1 = Console.ReadLine();
                        string[] str1 = string1.Split(' ', ',');
                        for (int j = 0; j < str1.Length; j++) { Neighbours2.Add(str1[j]); }
                    }

                    if (i == 2)
                    {
                        string string1 = Console.ReadLine();
                        string[] str1 = string1.Split(' ', ',');
                        for (int j = 0; j < str1.Length; j++) { Neighbours3.Add(str1[j]); }
                    }

                    if (i == 3)
                    {
                        string string1 = Console.ReadLine();
                        string[] str1 = string1.Split(' ', ',');
                        for (int j = 0; j < str1.Length; j++) { Neighbours4.Add(str1[j]); }
                    }

                    if (i == 4)
                    {
                        string string1 = Console.ReadLine();
                        string[] str1 = string1.Split(' ', ',');
                        for (int j = 0; j < str1.Length; j++) { Neighbours5.Add(str1[j]); }
                    }

                    if (i == 5)
                    {
                        string string1 = Console.ReadLine();
                        string[] str1 = string1.Split(' ', ',');
                        for (int j = 0; j < str1.Length; j++) { Neighbours6.Add(str1[j]); }
                    }

                }

                //We've neighbours list ready.


                //SECOND INPUT:
                Console.WriteLine();

                String line2;
                try
                {
                    //Pass the file path and file name to the StreamReader constructor
                    Console.WriteLine("Introduce the scenario's directory: ");
                    String Directory2 = Console.ReadLine();
                    StreamReader sr2 = new StreamReader(Directory2);

                    List<string> variables2 = new List<string>();


                    //Read the first line of text
                    line2 = sr2.ReadLine();

                    //Continue to read until you reach end of file
                    while (line2 != null)
                    {
                        //write the lie to console window
                        //Console.WriteLine(line);
                        variables2.Add(line2);
                        //Read the next line
                        line2 = sr2.ReadLine();

                    }

                    foreach (string variable2 in variables2)
                    {
                        Console.WriteLine(variable2);
                    }

                    //We have to separate variables
                    char[] delimiterChars2 = { ' ' };
                    //List<string> IDs = new List<string>();
                    string[] ConnectionID = new string[10];
                    string[] SenderID = new string[10];
                    string[] ReceiverID = new string[10];

                    for (int i = 0; i < 2; i++)
                    {

                        string var = variables2[i]; //Correspondent line
                        string[] var2 = var.Split(delimiterChars); //Splitting
                        ConnectionID[i] = var2[0];
                        SenderID[i] = var2[1];
                        ReceiverID[i] = var2[2];

                        Console.WriteLine("<{0}><{1}><{2}>", ConnectionID[i], SenderID[i], ReceiverID[i]);
                    }

                    Console.WriteLine();
                    Console.WriteLine("Connection IDs: ");
                    foreach (string ConnectionID1 in ConnectionID)
                    {
                        Console.Write(ConnectionID1);
                        Console.Write(" ");
                    }

                    Console.WriteLine();
                    Console.WriteLine("SenderID: ");
                    foreach (string Sender in SenderID)
                    {
                        Console.Write(Sender);
                        Console.Write(" ");
                    }

                    Console.WriteLine();
                    Console.WriteLine("ReceiverID: ");
                    foreach (string Receiver in ReceiverID)
                    {
                        Console.Write(Receiver);
                        Console.Write(" ");
                    }

                    //A sends to B: 
                    // time : Delays average from A to B
                    // connection id, node id, source id, dest id, direct dest id -> the previous node
                    string space = " ";
                    for (int i = 0; i < ReceiverID.Length; i++)
                    {
                        if (ReceiverID[i] == space) { Array.Clear(ReceiverID, i, 1); }
                    }
                    foreach (string Receiver in ReceiverID)
                    {
                        Console.Write(Receiver);
                        Console.Write(" ");
                    }



                    bool b = false;
                    Console.WriteLine();
                    Console.WriteLine("Tamaño receiver id:  {0}", ReceiverID.Length);
                    foreach (string a in Neighbours1)
                    {/*
                            for (int j = 0; j < Neighbours1.Capacity; j++)
                            {
                            if (b = Neighbours1.Contains(ReceiverID[j])) { break; }
                            else { b = false; }
                            Console.WriteLine(ReceiverID[j]);
                            Console.WriteLine(b);
                        }*/                                                 //IT DOESN'T WORK!!! ????

                    }
                    Console.WriteLine(b);
                    if (b == true) { Console.WriteLine("Match"); }
                    else { Console.WriteLine("Not match"); }                   //IT DOESN'T WORK!!! ????


                    //Console.Write("<time: {0}><connection id: {1}>, <source id: {2}>, <dest id: {3}>, <direct dest id: {4}>", Delays ????)
                    // }



                    //close the second file
                    sr2.Close();
                    Console.ReadLine();



                } //try2

                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }


                //close the file
                sr.Close();
                Console.ReadLine();

            } //try
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}