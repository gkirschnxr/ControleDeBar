using ControleDeBar.Dominio.ModuloMesa;
using ControleDeBar.Infraestrura.Arquivos.Compartilhado;

namespace ControleDeBar.Infraestrutura.Arquivos.ModuloMesa;

public class RepositorioMesa : RepositorioBase<Mesa>, IRepositorioMesa
{
    public RepositorioMesa(ContextoDados contexto) : base(contexto) { }

    protected override List<Mesa> ObterRegistros() {
        return contexto.Mesas;
    }
}
