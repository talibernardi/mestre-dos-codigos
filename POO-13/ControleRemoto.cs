
namespace POO_13
{
    public class ControleRemoto
    {
        public ControleRemoto(Televisao televisao)
        {
            Televisao = televisao;
        }
        public Televisao Televisao { get; set; }

        public void TrocarDeCanal(int canal)
        {
            Televisao.Canal = canal;
        }

        public void AumentarVolume()
        {
            Televisao.Volume++;
        }

        public void DiminuirVolume()
        {   if (Televisao.Volume >= 0)
            {
                Televisao.Volume--;
            }
        }

        public void AumentarCanal()
        {
            Televisao.Canal++;
        }

        public void DiminuirCanal()
        {   if (Televisao.Canal >= 0)
            {
                Televisao.Canal--;
            }
        }

        public int ConsultaCanal()
        {
            return Televisao.Canal; 
        }

        public int ConsultaVolume()
        {
            return Televisao.Volume;
        }
    }
}
