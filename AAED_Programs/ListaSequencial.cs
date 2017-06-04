using System;
using System.Collections.Generic;
using System.Text;


namespace AAED_Programs

{
    using TipoChave = System.Int32;
    class ListaSequencial
    {

        public class Registro
        {
            public TipoChave chave;

        }
        public class Lista
        {
            public Registro[] A = new Registro[int.MaxValue];
            public int nroElem;

        }
        public void Inicializar(Lista l)
        {
            l.nroElem = 0;
        }

        public bool InserirListaOrd(Lista l, Registro r)
        {
            if (l.nroElem == int.MaxValue) return false;
            int p = l.nroElem;
            while (p > 0 && l.A[p - 1].chave > r.chave)
            {
                l.A[p] = r;
                l.nroElem++;
            }
            return true;
        }

        public int BuscaSeq(Lista l, TipoChave ch)
        {
            int i = 0;
            while (i < l.nroElem)
            {
                if (ch == l.A[i].chave) return i;
                i++;
            }
            return -1;
        }
        public int BuscaSeqSent(Lista l, TipoChave ch)
        {
            int i = 0;
            l.A[l.nroElem].chave = ch + 1;
            while (l.A[i].chave < ch) i++;

            if (i == l.nroElem || l.A[i].chave != ch) return -1;
            else return i;


        }


    }
}
