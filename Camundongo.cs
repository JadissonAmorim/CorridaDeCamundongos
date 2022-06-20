namespace EntityCamundogos;
    class Camundongo{
        public string Name {get; set;}
        public int Distancia {get; set;}
        public int Colocação {get; set;}

        public Camundongo(string name, int distancia, int colocação){
            Name = name;
            Distancia = distancia;
            Colocação = colocação;
        }
        public void Mover(){
            Random rd = new Random();
            int rand_num = rd.Next(0, 10);
            Distancia += rand_num;
            if(Distancia > 100){
                Distancia = 100;
            }
        }
        public override string ToString()
    {
        return Name + " : " + Distancia;
    }
        public int position(int posicao){
            if(Distancia == 100 && Colocação == 0){
                    Colocação = posicao;
                    posicao++;
                    return posicao;
            }
            return posicao;
        }
    }