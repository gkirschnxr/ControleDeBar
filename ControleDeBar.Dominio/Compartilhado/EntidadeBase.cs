namespace ControleDeBar.Dominio.Compartilhado;

public abstract class EntidadeBase<T>
{
    Guid Id { get; set; }

    public abstract void AtualizarRegistro(T registroEditado);
}