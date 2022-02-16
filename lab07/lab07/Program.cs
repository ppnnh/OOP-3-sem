/*Растение, Куст, Цветок, Роза, Гладиолус, Кактус, Бумага, Букет*/
using System;
using System.Diagnostics;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace lab07
{
    class Program
    {
        static void Main(string[] args)
        {
            //int? aa = null;
            //Debug.Assert(aa != null, "Values array cannot be null");

            for (int i = 1; i < 7; i++)
            {
                try
                {
                    switch (i)
                    {
                        case 1:
                            Rose re = new Rose(-567, 6, "red");
                            break;

                        case 2:
                            Gladiolus cr = new Gladiolus(589, -7, "yellow");
                            break;

                        case 3:
                            Flower rb = new Flower(15, 3, "");
                            break;

                        case 4:
                            Bouqeut cr2 = new Bouqeut(-394);
                            break;

                        case 5:
                            int a = 0;
                            int b = 20 / a;
                            break;

                        case 6:
                            int[] arr = new int[2] { 0, 2 };
                            int q = arr[2];
                            break;
                    }
                }
                catch (BException ex)
                {
                    Console.WriteLine(ex.Message);
                    // throw;
                }
                catch (FException ex)
                {
                    Console.WriteLine(ex.Message);
                    // throw;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                //catch
                //{
                //    Console.WriteLine($"Универсальный catch");
                //}
                finally
                {
                    Console.WriteLine($"Это сообщение из блока finnaly");
                    Console.WriteLine("-------------------------------");
                }
            }
        }
    }
}


