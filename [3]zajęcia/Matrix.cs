using System;
using System.Collections.Generic;
using System.IO;        // do StreamReader
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_zajęcia
{
    class Matrix
    {
        private uint _numOfRows, _numOfCols;
        private int[,] _tab2D;
        
        public Matrix(string fileName)
        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;

            string pathFile = projectDirectory + @"\" + fileName;           // znak '@' przed stringiem będzie interpertował znak '\' jako zwykły znak '\' a nie definicję znaku specjalnego (np. '\n') - wykorzystuje się to m.in. do ścieżki pliku w Windowsie

            StreamReader sr = new StreamReader(pathFile);
            string line = sr.ReadLine();

            // zczytanie liczby kolumn
            _numOfCols = Convert.ToUInt32(sr.ReadLine().Split(' ').Length);

            // zliczenie liczby wierszy
            _numOfRows = 1;
            while (line != null)
            {
                line = sr.ReadLine();
                _numOfRows++;
            }
            sr.Close();                                     // zamykamy plik

            // zczytywanie wartości
            _tab2D = new int[_numOfRows, _numOfCols];
            String input = File.ReadAllText(pathFile);
            int i = 0, j = 0;
            foreach (var row in input.Split('\n'))
            {
                j = 0;
                foreach (var col in row.Trim().Split(' '))
                {
                    _tab2D[i, j] = int.Parse(col.Trim());
                    j++;
                }
                i++;
            }
        }

        public Matrix(uint numOfRows, uint numOfCols)                               // do tworzenia marzierzy wynikowych
        {
            _numOfRows = numOfRows;
            _numOfCols = numOfCols;
            _tab2D = new int[_numOfRows, _numOfCols];
        }

        public Matrix transposition()                                               // transpozycja macierzy
        {
            // tworzenie macierzy wynikowej
            uint
                numOfRows_T = _numOfCols,
                numOfCols_T = _numOfRows;
            Matrix tab2D_T = new Matrix(numOfRows_T, numOfCols_T);

            // transpozycja macierzy
            for (uint i = 0; i < _numOfRows; i++) {
                for (uint j = 0; j < _numOfCols; j++) {
                    tab2D_T._tab2D[j, i] = _tab2D[i, j];
                }
            }
            return tab2D_T;
        }
        
        public static Matrix operator + (Matrix tab2D_A, Matrix tab2D_B)            // dodawanie macierzy
        {
            // warunek sprawdzający, czy można wykonać dodawanie macierzy
            if (tab2D_A.returnNumOfRows() != tab2D_B.returnNumOfRows() || tab2D_A.returnNumOfCols() != tab2D_B.returnNumOfCols()) {
                Console.WriteLine("Nie można dodać macierzy o różnych wymiarach");
                return null;
            }

            // tworzenie macierzy wynikowej
            uint
            numOfRows_Add = tab2D_A.returnNumOfRows(),
            numOfCols_Add = tab2D_A.returnNumOfCols();
            Matrix tab2D_Add = new Matrix(numOfRows_Add, numOfCols_Add);

            // dodawanie macierzy
            for (uint i = 0; i < numOfRows_Add; i++) {
                for (uint j = 0; j < numOfCols_Add; j++) {
                    tab2D_Add._tab2D[i, j] = tab2D_A._tab2D[i, j] + tab2D_B._tab2D[i, j];
                }
            }
            return tab2D_Add;
        }
        
        public static Matrix operator * (Matrix tab2D_A, Matrix tab2D_B)            // mnożenie macierzy
        {
            // warunek sprawdzający, czy można wykonać mnożenie macierzy
            if (tab2D_A.returnNumOfCols() != tab2D_B.returnNumOfRows()) {
                Console.WriteLine("Nie można pomnożyć wybranych macierzy");
                return null;
            }

            // tworzenie macierzy wynikowej
            uint
                numOfRows_Multi = tab2D_A.returnNumOfRows(),
                numOfCols_Multi = tab2D_B.returnNumOfCols();
            Matrix tab2D_Multi = new Matrix(numOfRows_Multi, numOfCols_Multi);

            // mnożenie macierzy
            for (uint i = 0; i < tab2D_A.returnNumOfRows(); i++) {
                for (uint j = 0; j < tab2D_B.returnNumOfCols(); j++) {
                    int pom = 0;
                    for (uint k = 0; k < tab2D_A.returnNumOfCols(); k++) pom += tab2D_A._tab2D[i, k] * tab2D_B._tab2D[k, j];
                    tab2D_Multi._tab2D[i, j] = pom;
                }
            }
            return tab2D_Multi;
        }

        /*********************************************************************************
        // za pomocą zwykłej funkcji - bez przeciążenia
        public void addition() // dodawanie macierzy
        {
            if (numOfRows_A != numOfRows_B || numOfCols_A != numOfCols_B) {
                Console.WriteLine("Nie można dodać macierzy o różnych wymiarach");
                return;
            } 
            for (uint i = 0; i < numOfRows_A; i++) {
                for (uint j = 0; j < numOfCols_A; j++) {
                    tab2D_Add[i,j] = tab2D_A[i,j] + tab2D_B[i,j];
                }
            }
        }
        
        // za pomocą zwykłej funkcji - bez przeciążenia
        public void multiplication()            // mnożenie macierzy
        {
            if (numOfCols_A != numOfRows_B)
            {
                Console.WriteLine("Nie można pomnożyć wybranych macierzy");
                return;
            }
            for (uint i = 0; i < numOfRows_A; i++) {
                for (uint j = 0; j < numOfCols_B; j++) {
                    int pom = 0;
                    for (uint k = 0; k < numOfCols_A; k++) pom += tab2D_A[i, k] * tab2D_B[k, j];
                    tab2D_Multi[i, j] = pom;
                }
            }
        }
        *********************************************************************************/

        public void show(string k_nameOfMatrix)                                     // wyświetlenie macierzy
        {
            if (_tab2D == null) return;

            const int k_MiejsceKursora = 0;
            Console.WriteLine(k_nameOfMatrix + " =");
            for (uint i = 0; i < _numOfRows; i++) {
                int miejsceKursora = k_MiejsceKursora;
                for (uint j = 0; j < _numOfCols; j++) {
                    Console.CursorLeft = miejsceKursora;
                    Console.Write(_tab2D[i, j]);
                    miejsceKursora += 7;
                }
                Console.Write("\n");
            }
            Console.Write("\n\n");
        }

        public uint returnNumOfRows()                                               // zwróć liczbę wierszy macierzy
        {
            return _numOfRows;
        }
        
        public uint returnNumOfCols()                                               // zwróć liczbę kolumn macierzy
        {
            return _numOfCols;
        }
    }
}
