using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SocieteEnumerateur.ListeChainee
{
    class ListeEnumeration : IEnumerator<Liste>
    {
        private Liste _liste;
        private int _idCourant = 0;
        Liste IEnumerator<Liste>.Current => throw new NotImplementedException();
        object IEnumerator.Current => throw new NotImplementedException();

        public ListeEnumeration(Liste liste)
        {
            _liste = liste;
        }
        public object Current()
        {
            return _idCourant;
        }
        public void Dispose()
        {

            _liste = null;
            _idCourant = 0;
        }

        public bool MoveNext()
        {
            _idCourant++;
            if (_idCourant > _liste.NbElement )
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void Reset()
        {
            _idCourant = 0;
        }

    }
}
