﻿using System.Reflection.Metadata.Ecma335;

namespace MinecraftDistributionMapLiquidationer;

internal class MDML
{
    //const
    protected const string advancements = "advancements";

    protected const string data = "data";
    protected const string datapacks = "datapacks";
    protected const string DIM1 = "DIM1";
    protected const string DIM_1 = "DIM-1";
    protected const string playerdata = "playerdata";
    protected const string poi = "poi";
    protected const string stats = "stats";
    protected const string level_dat_old = "level.dat_old";
    protected const string session_lock = "session.lock";


    //default color
    readonly protected static ConsoleColor defaultColor = Console.ForegroundColor;

    private static void Main(string[] args)
    {
        //instanses
        Programs.SelectFolder selectFolder = new();
        Programs.Liquidation liquidation = new();

        string target = "";

        //about
        Console.WriteLine
            ("Hello!\n" +
            "This is Minecraft distribution map liquidationer.\n" +
            "====================\n" +
            "version 0.0.1\n" +
            "Kyuri\n" +
            "2024\n" +
            "MIT License https://opensource.org/license/mit/\n" +
            "====================\n");

        //folderinfo
        Console.WriteLine
            ("<Folder Information>\n" +
            $"{advancements} : players advancement\n" +
            $"{data} : map,scoreboard,raids\n" +
            $"{datapacks} : datapack\n" +
            $"{playerdata} : player's data tag\n" +
            $"{poi} : villager's data tag\n" +
            $"{stats} : player's statistics data\n" +
            $"{level_dat_old} : backup of level.dat\n" +
            $"{session_lock} : last access time\n");

    //goto label
    loop:

        //ask
        try
        {
            target = selectFolder.ReadFolderPath();
        }
        catch (DirectoryNotFoundException ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine
                ("**Error**\n" +
                "This File Path is not Found.\n\n" +
                "<Stack Trace>" +
                ex.StackTrace);
            goto loop;
        }
        catch (NullReferenceException ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine
                ("**Error**\n" +
                "This File Path is Null.\n\n" +
                "<Stack Trace>\n" +
                ex.StackTrace);
            goto loop;
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine
                ("**Error**\n" +
                "<Stack Trace>\n" +
                ex.StackTrace);
            return;
        }
        finally { Console.ForegroundColor = defaultColor; }

        //corret
        if (target[target.Length..] == "\\")
        {
            Console.WriteLine("Folder paths have been corrected.\n");
#pragma warning disable CA1806 // メソッドの結果を無視しない
            target.Remove(target.Length);
#pragma warning restore CA1806 // メソッドの結果を無視しない
            Console.WriteLine(target);
        }

        //liquidation
        liquidation.Liquidationer(target);
    }
}