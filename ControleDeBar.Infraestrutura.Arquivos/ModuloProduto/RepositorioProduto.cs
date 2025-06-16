using ControleDeBar.Dominio.ModuloProduto;
using ControleDeBar.Infraestrura.Arquivos.Compartilhado;

namespace ControleDeBar.Infraestrutura.Arquivos.ModuloProduto;

public class RepositorioProduto : RepositorioBase<Produto>, IRepositorioProduto
{
    public RepositorioProduto(ContextoDados contexto) : base(contexto) {
    }

    protected override List<Produto> ObterRegistros() {
        return contexto.Produtos;
    }
}