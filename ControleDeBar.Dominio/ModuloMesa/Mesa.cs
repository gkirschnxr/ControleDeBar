using ControleDeBar.Dominio.Compartilhado;

namespace ControleDeBar.Dominio.ModuloMesa;

public class Mesa : EntidadeBase<Mesa>
{
    public int Numero { get; set; }
    public int Lugares { get; set; }
    public bool EstaOcupada { get; set; }

    public Mesa() { }

    public Mesa(int numero, int lugares) {
        Id = Guid.NewGuid();
        Numero = numero;
        Lugares = lugares;
        EstaOcupada = false;
    }

    public void Ocupar() { EstaOcupada = true; }
    public void Desocupar() { EstaOcupada = false; }

    public override void AtualizarRegistro(Mesa registroEditado) {
        Numero = registroEditado.Numero;
        Lugares = registroEditado.Lugares;
    }
}
