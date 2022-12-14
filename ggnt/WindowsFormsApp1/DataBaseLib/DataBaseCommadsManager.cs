using DataBaseLib.Access;
using DataBaseLib.Commands;
using System.Data;

namespace DataBaseLib;

/// <summary>
/// Выполнение команд пользователя
/// </summary>
public class DataBaseCommadsManager
{
    public DataBaseCommadsManager manager { get; set; }

    public DataTable GetDataTable(string tableName)
    {
        BaseCommands command = new BaseCommands();        
        return command.GetDataTable(tableName);
    }

    public void Insert(string[] args, string tableName)
    {
        ITableEditorCommand command;
        switch(tableName)
        {
            case "Ученики": command = new Table1Commands();
                break;
            case "Тарифы":
                command = new TarifCommand();
                break;
            case "Преподователя":
                command = new TeacharCommand();
                break;
            case "Классы":
                command = new classsCommand();
                break;
            case "Расписание":
                command = new ScheduleCommand();
                break;
            default: throw new Exception("Ошибка!");
        }
        command.Insert(args);
    }

    public void Update(string[] args,string tabeleName)
    {
        ITableEditorCommand command;
        switch(tabeleName)
        {
            case "Ученики":
                command = new Table1Commands();
                break;
            case "Тарифы":
                command = new TarifCommand();
                break;
            case "Преподователя":
                command = new TeacharCommand();
                break;
            case "Классы":
                command = new classsCommand();
                break;
            case "Расписание":
                command = new ScheduleCommand();
                break;
            default: throw new Exception("Ошибка!");
        }
        command.Update(args);
    }

    public void Delete(int number, string tabelName)
    {
        ITableEditorCommand command;
        switch(tabelName)
        {
            case "Ученики":
                command = new Table1Commands();
                break;
            case "Тарифы":
                command = new TarifCommand();
                break;
            case "Преподователя":
                command = new TeacharCommand();
                break;
            case "Классы":
                command = new classsCommand();
                break;
            case "Расписание":
                command = new ScheduleCommand();
                break;
            default: throw new Exception("Ошибка");
        }
        command.Delete(number);
    }
    public void Select(string[] args, string tabeleName)
    {
        ITableEditorCommand command;
        switch (tabeleName)
        {
            case "Ученики":
                command = new Table1Commands();
                break;
            case "Тарифы":
                command = new TarifCommand();
                break;
            case "Преподователя":
                command = new TeacharCommand();
                break;
            case "Классы":
                command = new classsCommand();
                break;
            case "Расписание":
                command = new ScheduleCommand();
                break;
            default: throw new Exception("Ошибка!");
        }
        command.Select(args);
    }
    // Домашнее задание
    // 1. Дописать логику методов Update, Delete
    // 2. Продумать структуру БД по вариантам
    // 3. Использовать Access или SQLite

}
