using JlucsxCourses.SharedContext;

namespace JlucsxCourses.ContentContext;

/*Um objeto "conteúdo" instanciado
 * não faz sentido, no contexto de
 * uma empresa que vende cursos...
 * "Conteúdo" deveria ser um artigo,
 * um curso, uma apostila, uma coleção
 * de cursos (carreira)...
 * Conteúdo, por si só, é ABSTRATO.
 */
public abstract class Content : Base
{
    public Content(string title, string url)
    {
        Title = title;
        Url = url;
    }

    public string Title { get; set; }
    public string Url { get; set; }
}
