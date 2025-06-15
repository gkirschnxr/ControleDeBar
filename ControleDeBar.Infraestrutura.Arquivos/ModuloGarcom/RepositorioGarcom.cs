using ControleDeBar.Dominio.ModuloGarcom;
using ControleDeBar.Infraestrura.Arquivos.Compartilhado;

namespace ControleDeBar.Infraestrutura.Arquivos.ModuloGarcom;

public class RepositorioGarcom : RepositorioBase<Garcom>, IRepositorioGarcom
{
    public RepositorioGarcom(ContextoDados contexto) : base(contexto) { }

    protected override List<Garcom> ObterRegistros() {
        return contexto.Garcons;
    }
}