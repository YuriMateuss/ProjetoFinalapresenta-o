using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProejtoFinalPEOOFabricantedeVeiculos
{
         class NFabricante
    {
        private static List<Fabricante> fabricantes = new List<Fabricante>();
        public static void Inserir(Fabricante t)
        {
            Abrir();
            int id = 0;
            foreach (Fabricante obj in fabricantes)
                if (obj.Id > id) id = obj.Id;
            t.Id = id + 1;
            fabricantes.Add(t);
            Salvar();
        }
        public static List<Fabricante> Listar()
        {
            Abrir();
            return fabricantes;
        }
        public static void Atualizar(Fabricante t)
        {
            Abrir();
            foreach (Fabricante obj in fabricantes)
                if (obj.Id == t.Id)
                {
                    obj.Nome = t.Nome;
                }
            Salvar();
        }

        public static void Excluir(Fabricante t)
        {
            Abrir();
            Fabricante x = null;
            foreach (Fabricante obj in fabricantes)
                if (obj.Id == t.Id) x = obj;
            if (x != null) fabricantes.Remove(x);
            Salvar();
        }
        public static void Abrir()
        {
            StreamReader f = null;
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Fabricante>));
                f = new StreamReader("./fabricante.xml");
                fabricantes = (List<Fabricante>)xml.Deserialize(f);
            }
            catch
            {
                fabricantes = new List<Fabricante>();
            }
            if (f != null) f.Close();
        }
        public static void Salvar()
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Fabricante>));
            StreamWriter f = new StreamWriter("./fabricante.xml", false);
            xml.Serialize(f, fabricantes);
            f.Close();
        }
  }
}