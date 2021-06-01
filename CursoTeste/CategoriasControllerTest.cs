using CursoMVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CursoTeste
{
    public class CategoriasControllerTest
    {
        private readonly Mock<DbSet<Categoria>> _mockSet;
        private readonly Mock<Context> _mockContext;
        private readonly Categoria _categoria;

        public CategoriasControllerTest(Context @object)
        {
            Object = @object;
        }

        public CategoriasControllerTest(Mock<Context> _mockContext, object objecto)
        {
            _mockSet = new Mock<DbSet<Categoria>>();
            _mockContext = new Mock<Context>();
            _categoria = new Categoria { id = 1, descricao = "Teste categoria" };
            _mockContext.Setup(expression: m => m.Categorias).Returns(_mockSet.Object);
            //_mockContext.Setup(expression: m => m.Categorias.FindAsync(KeyValues(1)).RetunsAsync(_categoria);
        }

        public object Objecto { get; private set; }
        public Context Object { get; }

        [Fact]
   
         public async Task Get_Categoria(int v)
         {
              var service = new CategoriasControllerTest(_mockContext.Object);
              await service.Get_Categoria(1);
             _mockSet.Verify(expression: m => (KeyValues(1)), Times.Once());
             // Assert.Equals(_categoria.id, actual: testeCategoria.id);

        }

        private object KeyValues(int v)
        {
            throw new NotImplementedException();
        }
    }
    }

