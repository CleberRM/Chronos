using br.com.Chronos.Entidade;
using br.com.Chronos.FakeRepositorio;
using br.com.Chronos.Negocio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.com.Chronos.TestesUnitarios
{
    [TestClass]
    public class TesteSetor
    {
        private static IAcoesBanco<Setor> _acoesBanco;
        private static BLSetor _blSetor;
        [TestInitialize]
        public void Inicializador()
        {
            if (_acoesBanco == null)
            {
                _acoesBanco = new RepositorioFake<Setor>();
                _blSetor = new BLSetor(_acoesBanco);
                Setor setor = new Setor();
                setor.Descricao = "Desenvolvimento";
                _blSetor.Salvar(setor);
            }
        }

        [TestMethod]
        public void TestarInclusaoSetor()
        {
            Setor setor = new Setor();
            setor.Descricao = "Suporte";
            _blSetor.Salvar(setor);

            Setor setorDesenvolvimento = _blSetor.RetornarEntidadePor(1);
            Setor setorSuporte = _blSetor.RetornarEntidadePor(2);

            Assert.AreEqual(1, setorDesenvolvimento.Id);
            Assert.AreEqual("Desenvolvimento", setorDesenvolvimento.Descricao);

            Assert.AreEqual(2, setorSuporte.Id);
            Assert.AreEqual("Suporte", setorSuporte.Descricao);
        }

        [TestMethod]
        public void TestarEdicaoSetor()
        {
            Setor setorDesenvolvimento = _blSetor.RetornarEntidadePor(1);
            setorDesenvolvimento.Descricao = "Documentação";
            _blSetor.Salvar(setorDesenvolvimento);

            Setor setorDocumentacao = _blSetor.RetornarEntidadePor(1);

            Assert.AreEqual("Documentação", setorDocumentacao.Descricao);
        }
    }
}
