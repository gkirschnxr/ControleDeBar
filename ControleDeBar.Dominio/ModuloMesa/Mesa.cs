using ControleDeBar.Dominio.Compartilhado;

namespace ControleDeBar.Dominio.ModuloMesa;

public class Mesa : EntidadeBase<Mesa>
{
    public int Numero { get; set; }
    public int Lugares { get; set; }

    public Mesa() { }

    public Mesa(int numero, int lugares) {
        Id = Guid.NewGuid();
        Numero = numero;
        Lugares = lugares;
    }
    public override void AtualizarRegistro(Mesa registroEditado) {
        Numero = registroEditado.Numero;
        Lugares = registroEditado.Lugares;
    }
}
