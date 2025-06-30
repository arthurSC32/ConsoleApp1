using System.Net.Http.Json;
using System.Threading.Tasks;

class programa
{
    public static async Task Main(String[] args)
    {
        usuario usuario = await obter();
        Console.WriteLine("id " +usuario.id);
        Console.WriteLine("title "+usuario.title);
        Console.WriteLine("userid "+usuario.userId);

    }
    

        
       
       


    public static async Task<usuario>  obter() {

        string url = "https://jsonplaceholder.typicode.com/todos/1";
        HttpClient httpClient = new HttpClient();
        var resposta = await httpClient.GetFromJsonAsync<usuario>(url);
        return resposta;


    }

}
class usuario
{
   public  int userId {  get; set; }
  public   int id { get; set; }
  public  string title { get; set; }
  public  bool completed { get; set; }


}