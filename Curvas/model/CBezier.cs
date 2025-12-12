using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURVAS.Curvas.model
{
    // Clase para el manejo de la lógica matemática de Bézier
    public class CBezier
    {
        // Factorial simple para calcular coeficientes binomiales
        private long Factorial(int n)
        {
            if (n <= 1) return 1;
            long result = 1;
            for (int i = 2; i <= n; i++) result *= i;
            return result;
        }

        // Coeficiente Binomial (n sobre k)
        private long Binomial(int n, int k)
        {
            return Factorial(n) / (Factorial(k) * Factorial(n - k));
        }

        // Calcula un punto en la curva para un tiempo t (0 <= t <= 1)
        // Algoritmo explícito de Bernstein
        public PointF CalcularPunto(float t, List<PointF> puntosControl)
        {
            int n = puntosControl.Count - 1;
            float x = 0, y = 0;

            for (int i = 0; i <= n; i++)
            {
                // Polinomio de Bernstein: B(n,i) * (1-t)^(n-i) * t^i
                long coef = Binomial(n, i);
                double term = coef * Math.Pow(1 - t, n - i) * Math.Pow(t, i);

                x += (float)(term * puntosControl[i].X);
                y += (float)(term * puntosControl[i].Y);
            }

            return new PointF(x, y);
        }
    }
}
