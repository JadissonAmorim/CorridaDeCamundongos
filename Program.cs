using System;
using EntityCamundogos;
using System.Linq;
namespace Course;
    class Program{
        static void Main(string[] args) {
            int posicao = 1;
            List<Camundongo> camundongos = new List<Camundongo>(){
                new Camundongo("Camundongo A", 0, 0),
                new Camundongo("Camundongo B", 0, 0),
                new Camundongo("Camundongo C", 0, 0),
                new Camundongo("Camundongo D", 0, 0)
            };
            var r1 = camundongos.Where(p => p.Colocação == 0).FirstOrDefault();
            while (r1 != null){
                Console.WriteLine();
                foreach(Camundongo camun in camundongos){
                Console.WriteLine(camun.ToString());
                camun.Mover();
                posicao = camun.position(posicao);
                }   
                Console.WriteLine();
                r1 = camundongos.Where(p => p.Colocação == 0).FirstOrDefault();
                Console.ReadKey();
            } 
            var ranking = camundongos.OrderBy(p => p.Colocação);
            foreach(Camundongo camun in ranking){
                Console.WriteLine(camun.Colocação + "º - " + camun.Name);
            }            
        }
    }    
    

