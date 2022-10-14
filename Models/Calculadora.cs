using System.ComponentModel.DataAnnotations;


namespace PSP_Trabajo.Models
{
    public class Calculadora
    {
        [Required]
        public double NumeroA { get; set; }

        [Required]
        public double NumeroB { get; set; }

        public Calculadora()
        {
        }

        public double CalcularValor()
        {
            if (NumeroA > NumeroB)
            {
                return RestarAyB();
            }
            else if (NumeroA < NumeroB)
            {
                return SumarAyB();
            }
            else
            {
                return 0;
            }
        }

        private double SumarAyB()
        {
            return NumeroA + NumeroB;
        }

        private double RestarAyB()
        {
            return NumeroA - NumeroB;
        }
    }

}