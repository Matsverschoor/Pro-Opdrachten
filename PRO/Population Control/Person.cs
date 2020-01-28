using System;
namespace Les3PopulationControl
{
    public class Person
    {
        private string name;
        public string GetName(){
            return this.name;
        }   
        public void SetName(string name){            
            foreach(Char c in name){             
                if(Char.IsDigit(c) || c <= 4){
                    Console.WriteLine("name is not valid");
                    return;
                }
            }
            this.name = name;
        }

        private string ogen;
        public string GetOgen(){
            return this.ogen;
        }   

        
 
       public void SetOgen(string Ogen){          
           bool oogfound = false;  
            foreach(string c in Oogkleuren.LIST){             
                if(c == Ogen){
                    oogfound = true;
                }
            }
            if(oogfound == false){
                Console.WriteLine("Oogkleur is not valid");
            }
            this.ogen = Ogen;
        }

        private string lengte;
        public string GetLengte(){
            return this.lengte;
        }          
 
       public void SetLengte(string l){  
             int resLengte = 0;
             resLengte = System.Convert.ToInt32(l);
                if(resLengte > 220){
                    Console.WriteLine("Lengte is not valid");
                    return;
                }

                this.lengte = l;
            }
    
        

        private string leeftijd;
        
        public string GetLeeftijd(){
            return this.leeftijd;
        }   

        
 
       public void Setleeftijd(string leeftijd){  
            int resLeeftijd = 0;
            resLeeftijd = System.Convert.ToInt32(leeftijd);
                if(resLeeftijd >= 100){
                    Console.WriteLine("leeftijd is not valid");
                    return;
                }
                this.leeftijd = leeftijd;
            }
            
        

        private string geboorteland;
        public string GetGeboorteland(){
            return this.geboorteland;
        }   

        
 
       public void SetGeboorteland(string Geboorteland){            
           
           bool found = false;
           
            foreach(string c in CountryList.LIST){             
                if(c == Geboorteland){
                   found = true;
                }
            }

            if(found == false){
                Console.WriteLine("Geboorteland is not valid");
            }
            this.geboorteland = Geboorteland;
        }

        private string BSN;
        public string GetBSNNummer(){
            return this.BSN;
        }   

        
 
       public void SetBSN(string BSNNummer){            
            foreach(int c in BSNNummer){             
                if(c != 9){
                    Console.WriteLine("BSN is not valid");
                    return;
                }
            }
            this.BSN = BSNNummer;
        }

        

        public void SetCountry(string country){
            bool countryfound = false;
            foreach(string c in CountryList.LIST){
                if(c == country){
                    countryfound = true;
                }              
            }
            if(countryfound == false){
                Console.WriteLine("Country is not valid");
            }

        }
    }

}