using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class DocumentSaver
    {
        private static DocumentSaver _instance;

        
        private DocumentSaver()
        {
            
        }

        public static DocumentSaver Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DocumentSaver();
                }
                return _instance;
            }
        }

        public void SaveDocument(string document)
        {
            
        }

      
    }
}
