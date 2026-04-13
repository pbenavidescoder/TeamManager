using TeamManager.UI.Models;

namespace TeamManager.UI.Helpers
{
    public class ActivityTranslator
    {
       public static string TranslateActivity(Activity type) => type switch
        {
            Activity.Training => "Entrenamiento",
            Activity.Match => "Juego",
            Activity.Meeting => "Reunión",
            _ => type.ToString()
        };

    }
}
