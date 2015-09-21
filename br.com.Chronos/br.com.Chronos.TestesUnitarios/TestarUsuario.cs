using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using br.com.Chronos.Entidade;
using br.com.Chronos.Negocio;
using br.com.Chronos.FakeRepositorio;

namespace br.com.Chronos.TestesUnitarios
{
    [TestClass]
    public class TestarUsuario
    {

        [TestMethod]
        public void TestarClasseUsuario()
        {

            Setor setor = new Setor();
            setor.Descricao = "Projetos";

            Escritorio office = new Escritorio();
            office.NomeEscritorio = "Sao";

            Usuario user = new Usuario("Gian", "1",office, setor);

            IAcoesBanco<Usuario> acoesBanco = new RepositorioFake<Usuario>();

            BLUsuario blUsuario = new BLUsuario(acoesBanco);

            blUsuario.Salvar(user);

            Assert.AreEqual("Gian", user.NomeUsuario);
            
                

        }



    }
}
