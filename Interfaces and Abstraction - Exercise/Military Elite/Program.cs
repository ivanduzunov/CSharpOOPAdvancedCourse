using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Military_Elite
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<ISoldier> soldiers = new List<ISoldier>();


            var input = string.Empty;

            while ((input = Console.ReadLine().Trim()) != "End")
            {
                var tokens = input.Split(' ');
                switch (tokens[0])
                {
                    case "Private":
                        int id = int.Parse(tokens[1]);
                        string firstName = tokens[2];
                        string lastName = tokens[3];
                        double  salary = double.Parse(tokens[4]);
                        IPrivate sold = new Private(id, firstName, lastName, salary);
                        soldiers.Add(sold);
                        Console.WriteLine(sold.ToString());
                        break;


                    case "LeutenantGeneral":
                        var leutenant = new LeutenantGeneral(int.Parse(tokens[1]), tokens[2], tokens[3], double.Parse(tokens[4]));
                        if (tokens.Length > 5)
                        {
                            for (int i = 5; i < tokens.Length; i++)
                            {
                                leutenant.Privates.Add(soldiers.First(s => s.Id == int.Parse(tokens[i])));
                            }
                            soldiers.Add(leutenant);                          
                        }
                        Console.WriteLine(leutenant.ToString());
                        break;


                    case "Engineer":
                        if (tokens[5] == "Airforces" || tokens[5] == "Marines")
                        {
                            Engineer eng = new Engineer(int.Parse(tokens[1]), tokens[2], tokens[3], double.Parse(tokens[4]), tokens[5]);
                            if (tokens.Length > 6)
                            {
                                for (int i = 6; i < tokens.Length; i += 2)
                                {

                                    eng.Repairs.Add(new Repair(tokens[i], int.Parse(tokens[i + 1])));
                                }
                                soldiers.Add(eng);
                                Console.WriteLine(eng);
                            }
                        }

                        break;


                    case "Commando":
                        if (tokens[5] == "Airforces" || tokens[5] == "Marines")
                        {
                            Commando comm = new Commando(int.Parse(tokens[1]), tokens[2], tokens[3], double.Parse(tokens[4]), tokens[5]);
                            if (tokens.Length > 6)
                            {
                                for (int i = 6; i < tokens.Length; i += 2)
                                {
                                    if (tokens[i + 1] == "Finished" || tokens[i + 1] == "inProgress")
                                    {
                                        comm.Missions.Add(new Mission(tokens[i], tokens[i + 1]));
                                    }

                                }

                            }
                            soldiers.Add(comm);
                            Console.WriteLine(comm);
                        }
                        break;


                    case "Spy":
                        var spy = (new Spy(int.Parse(tokens[1]), tokens[2], tokens[3], int.Parse(tokens[4])));
                        soldiers.Add(spy);
                        Console.WriteLine(spy.ToString());
                        break;
                }
            }


        }
    }
}
