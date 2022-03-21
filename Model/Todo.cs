namespace MiniTodo.Model
{
   public record Todo(Guid Id, string Title, bool Done);

   //Antes de NET 6
   //public class Todo
   // {
   //     public Guid Id { get; set; }
   //     public string Title { get; set; }
   //     public bool Done { get; set; }
   // }
}
