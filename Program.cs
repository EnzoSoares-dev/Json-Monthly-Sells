using System;
using Newtonsoft.Json;
namespace Question_3{

    public class Program{
        static void Main(){
            double MenorValor=0,MaiorValor=0, DiaMaior=0,media=0, total=0;
            int Count=0;
            StreamReader reader = new StreamReader("dados.json");            
            string jsonToString = reader.ReadToEnd();            
            data[]? datas = JsonConvert.DeserializeObject<data[]>(jsonToString);                               

            for(int i=0;i<datas.Length;i++){                
                total += double.Parse(datas[i].valor.ToString("n2"));
                if(datas[i].valor !=0){
                    Count++;
                }
                if(MaiorValor==0 && MenorValor == 0){
                    MaiorValor = datas[i].valor;
                    MenorValor = datas[i].valor;
                }else{
                    if(datas[i].valor > MaiorValor){
                        MaiorValor = datas[i].valor;
                    }
                    if(datas[i].valor < MenorValor){
                        MenorValor = datas[i].valor;
                    }
                }                
            }
            media = total/Count;

            for(int i=0; i<datas.Length;i++){
                if(datas[i].valor>media){
                    DiaMaior++;
                }
            }

            System.Console.WriteLine("Média Mensal: "+media);
            System.Console.WriteLine("Maior valor de venda: "+MaiorValor);
            System.Console.WriteLine("Menor valor de venda: "+MenorValor);
            System.Console.WriteLine("Número de dias com valor maior que a média: "+DiaMaior);
        }
    }
}