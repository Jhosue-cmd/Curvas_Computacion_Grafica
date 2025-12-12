using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURVAS.Curvas.model
{
    // Clase para el manejo de la lógica matemática de B-Spline
    public class CBSpline
    {
        private int _orden; // Orden k (Grado = k - 1)

        public CBSpline(int orden)
        {
            // Validamos que el orden no sea negativo ni nulo (Requerimiento de validación)
            if (orden < 2) throw new ArgumentException("El orden debe ser al menos 2.");
            _orden = orden;
        }

        // Generar vector de nodos (Knot Vector) - Uniforme Abierto (Clamped)
        // Esto hace que la curva toque el primer y último punto, propiedad clave de B-Splines en diseño.
        private List<float> GenerarNodos(int n, int k)
        {
            List<float> nodos = new List<float>();
            int numNodos = n + k + 1;

            // Nodos iniciales (multiplicidad k)
            for (int i = 0; i < k; i++) nodos.Add(0f);

            // Nodos intermedios
            int pasos = numNodos - 2 * k;
            for (int i = 1; i <= pasos; i++)
            {
                nodos.Add((float)i / (pasos + 1));
            }

            // Nodos finales (multiplicidad k)
            for (int i = 0; i < k; i++) nodos.Add(1f);

            return nodos;
        }

        // Algoritmo de Cox-de Boor para calcular las funciones base
        private float BasisFunction(int i, int k, float t, List<float> nodos)
        {
            if (k == 1)
            {
                if (nodos[i] <= t && t < nodos[i + 1]) return 1f;
                // Caso especial para incluir el último punto exactamente
                if (t == 1f && nodos[i + 1] == 1f && nodos[i] < 1f) return 1f;
                return 0f;
            }

            float den1 = nodos[i + k - 1] - nodos[i];
            float den2 = nodos[i + k] - nodos[i + 1];

            float term1 = 0, term2 = 0;

            if (den1 != 0)
                term1 = ((t - nodos[i]) / den1) * BasisFunction(i, k - 1, t, nodos);

            if (den2 != 0)
                term2 = ((nodos[i + k] - t) / den2) * BasisFunction(i + 1, k - 1, t, nodos);

            return term1 + term2;
        }

        public PointF CalcularPunto(float t, List<PointF> puntosControl)
        {
            float x = 0, y = 0;
            int n = puntosControl.Count - 1; // n es índice del último punto
            int k = _orden;

            // Validación: Se necesitan al menos k puntos para definir una B-Spline de orden k
            if (puntosControl.Count < k) return PointF.Empty;

            List<float> nodos = GenerarNodos(n, k);

            for (int i = 0; i <= n; i++)
            {
                float b = BasisFunction(i, k, t, nodos);
                x += puntosControl[i].X * b;
                y += puntosControl[i].Y * b;
            }

            return new PointF(x, y);
        }
    }
}
