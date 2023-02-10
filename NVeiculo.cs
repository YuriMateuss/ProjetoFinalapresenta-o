using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProejtoFinalPEOOFabricantedeVeiculos
{
    public class NVeiculo
    {
        private static List<Veiculo> veiculos = new List<Veiculo>();
        public static void Inserir(Veiculo v)
        {
            Abrir();
            int id = 0;
            foreach (Veiculo obj in veiculos)
                if (obj.Id > id) id = obj.Id;
            v.Id = id + 1;
            veiculos.Add(v);
            Salvar();
        }
        public static List<Veiculo> Listar(Fabricante t)
        {
            Abrir();
            List<Veiculo> v = new List<Veiculo>();
            foreach(Veiculo x in veiculos)
            {
                if (x.IdFabricante == t.Id)
                    v.Add(x);
            }
            return v;
        }
        public static void Atualizar(Veiculo v)
        {
            Abrir();
            foreach (Veiculo obj in veiculos)
                if (obj.Id == v.Id)
                {
                    obj.Id = v.Id;
                    obj.Nome = v.Nome;
                    obj.IdFabricante = v.IdFabricante;
                }
            Salvar();
        }

        public static List<Veiculo> Listar()
        {
            Abrir();
            return veiculos;
        }

        public static void Excluir(Veiculo v)
        {
            Abrir();
            Veiculo x = null;
            foreach (Veiculo obj in veiculos)
                if (obj.Id == v.Id) x = obj;
            if (x != null) veiculos.Remove(x);
            Salvar();
        }
        public static void Abrir()
        {
            StreamReader f = null;
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Veiculo>));
                f = new StreamReader("./veiculos.xml");
                veiculos = (List<Veiculo>)xml.Deserialize(f);
            }
            catch
            {
                veiculos = new List<Veiculo>();
            }
            if (f != null) f.Close();
        }
        public static void Salvar()
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Veiculo>));
            StreamWriter f = new StreamWriter("./veiculos.xml", false);
            xml.Serialize(f, veiculos);
            f.Close();
        }
        public static void Cadastrar(Veiculo v, Fabricante f)
        {
            v.IdFabricante = f.Id;
            Atualizar(v);
        }
        public static List<Veiculo> Button_Click_1(Fabricante f)
        {
            Abrir();
            List<Veiculo> listdepartamentos = new List<Veiculo>();
            foreach (Veiculo obj in veiculos)
                if (obj.IdFabricante == f.Id) listdepartamentos.Add(obj);
            return listdepartamentos;
        }
    }
}