using Newtonsoft.Json;
using TestAscon;

var objectsList = GetObjectsList<SomeClass>("ShortSummary.json");
var listWithoutDublicates = DeleteSame(objectsList);
var json = ConvertToJson(listWithoutDublicates);
UpdateJsonFile(json);
Console.ReadKey();

// Получает список объектов на основе переданного json.
List<T> GetObjectsList<T>(string name) where T : class
{
    ConsoleLogHelper.StartDeserializationMessage();

    var path = Path.GetFullPath(name);

    if (!File.Exists(path))
    {
        ConsoleLogHelper.FileNotExistErrorMessage();

        throw new Exception();
    }

    var jsonString = File.ReadAllText(path);
    var someObjects = JsonConvert.DeserializeObject<List<T>>(jsonString);

    if (someObjects is null)
    {
        ConsoleLogHelper.FileIsEmptyErrorMessage();

        throw new Exception();
    }

    ConsoleLogHelper.EndDeserializationMessage();

    return someObjects;
}

// Удаляет дубликаты из переданного списка объектов.
List<SomeClass> DeleteSame(List<SomeClass> list)
{
    ConsoleLogHelper.StartDeleteDublicatesMessage();

    var result = new List<SomeClass>();

    foreach (var i in list)
    {
        if (!result.Exists(x => (x.rec_id == i.rec_id) &&
                                (x.timestamp == i.timestamp)))
        {
            result.Add(i);
        }
    }

    ConsoleLogHelper.EndDeleteDublicatesMessage();

    return result;
}

// Преобразует список объектов в строку json.
string ConvertToJson<T>(List<T> list) where T : class
{
    ConsoleLogHelper.StartSerializationMessage();

    string json = JsonConvert.SerializeObject(list);

    ConsoleLogHelper.EndSerializationMessage();

    return json;
}

// Обновляет json файл без дублирующих объектов.
async void UpdateJsonFile(string json)
{
    var path = Path.GetFullPath("ShortSummary.json");

    if (!File.Exists(path))
    {
        ConsoleLogHelper.FileNotExistErrorMessage();

        throw new Exception();
    }

    ConsoleLogHelper.StartUpdateFileMessage();

    using (var writer = new StreamWriter(path, false))
    {
        await writer.WriteLineAsync(json);
    }

    ConsoleLogHelper.EndUpdateFileMessage();
}