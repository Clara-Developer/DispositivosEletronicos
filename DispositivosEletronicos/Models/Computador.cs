namespace DispositivosEletronicos.Models
{
    //Essa linha herda 
 
    public class Computador : DispositivoEletronico
    {
        public bool EhLaptop { get; set; }
        public int MemoriaRam { get; set; }
        public string SistemaOperacional { get; set; }

        public override string ExibirDetalhes()
        {
            return $"Marca : {Marca}, Modelo: {Modelo}, Ano: {AnoDeFabricacao},, 50: {SistemaOperacional}"; 
        }
    }
}
