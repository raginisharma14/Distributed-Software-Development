using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfStemmingService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
        /*
         *GetStemWord is implemented based on PortStemmer algorithm 
         */
        public string GetStemWord(string stemwords)
        {
            string[] arrayofwords = stemwords.Split(',');

            string finalStemWord = "";
            for (int i = 0; i < arrayofwords.Length; i++)
            {
                string s = arrayofwords[i];
                int length = s.Length;
                String s1 = step1(length, s);
                String s2 = step2(length, s);
                Console.Write("mystringvalue" + s);
               
                    finalStemWord = finalStemWord + s1 + ',' + s2;
                
                
            }
            

            return finalStemWord;
        }
        public String step1(int i, string s)
        {
            switch(s.ElementAt(i-1))
            {
                case 'e':
                    if (s.EndsWith("icate"))
                    {
                      String endswithE =   s.Replace("icate", "ic");
                        return endswithE;


                    }
                    if (s.EndsWith("ative"))
                    {
                        String endswithE = s.Replace("ative", "");
                        return endswithE;
                    }
                    if (s.EndsWith("alize"))
                    {
                        String endswithE =  s.Replace("alize", "al");
                        return endswithE;


                    }
                        break;

                case 'i':
                    if (s.EndsWith("iciti"))
                    {

                        String endswithI = s.Replace("iciti", "ic");
                        return endswithI;
                    }
                    
                    break;
                case 'l':
                    if (s.EndsWith("ical"))
                    {
                        String endswithL = s.Replace("ical", "ic");
                        return endswithL;
                    }
                    if (s.EndsWith("ful"))
                    {
                        String endswithL = s.Replace("ful", "");
                        return endswithL;
                    }
                    break;

                case 's':
                    if (s.EndsWith("ness"))
                    {
                        String endswithS = s.Replace("ness", "");
                        return endswithS;
                    }
                    break;

                default:
                    return "";
                   

            }
            return s;

            
        }
        public String step2(int j, string s)
        {
           switch(s.ElementAt(j-2))
            {
                case 'a':
                    if (s.EndsWith("ational"))
                    {
                        String endswithA =  s.Replace("ational", "ate");
                        return endswithA;
                    }
                    if (s.EndsWith("tional"))
                    {
                        String endswithA =  s.Replace("tional", "tion");
                        return endswithA;
                    }
                    break;
                case 'c':
                    if (s.EndsWith("enci"))
                    {
                        String endswithC = s.Replace("enci", "ence");
                        return endswithC;
                    }
                    if (s.EndsWith("anci"))
                    {
                        String endswithC = s.Replace("anci", "ance");
                        return endswithC;
                    }
                    break;
                case 'e':
                    if (s.EndsWith("izer"))
                    {
                        String endswithE = s.Replace("izer", "ize");
                        return endswithE;
                    }
                    break;
                case 'o':
                    if (s.EndsWith("ization"))
                    {
                        String endswithO = s.Replace("ization", "ize");
                        return endswithO;
                    }
                    if (s.EndsWith("ation"))
                    {
                        String endswithO =  s.Replace("ation", "ate");
                        return endswithO;
                    }
                    break;
                case 'l':
                    if (s.EndsWith("bli"))
                    {

                        String endswithL =  s.Replace("bli", "ble");
                        return endswithL;
                    }
                    if (s.EndsWith("alli"))
                    {
                        String endswithL = s.Replace("alli", "al");
                        return endswithL;
                    }
                    if (s.EndsWith("entli"))
                    {
                        String endswithL = s.Replace("entli", "ent");
                        return endswithL;
                    }
                    if (s.EndsWith("eli"))
                    {
                        String endswithL = s.Replace("eli", "e");
                        return endswithL;
                    }
                    break;

                case 't':
                    if (s.EndsWith("aliti"))
                    {
                        String endswithT =  s.Replace("aliti", "al");
                        return endswithT;
                    }
                    if (s.EndsWith("iviti"))
                    {
                        String endswithT = s.Replace("iviti", "ive");
                        return endswithT;
                    }
                    if (s.EndsWith("biliti"))
                    {
                        String endswithT = s.Replace("biliti", "ble");
                        return endswithT;
                    }
                   
                    break;
                default:
                    return "";
                   
                    
           }

            return s;
        }
     
    }
}
