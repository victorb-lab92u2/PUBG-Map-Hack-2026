using System;
using System.IO;
namespace ModManager.Mewgenics.Utils;
public static class Logger{
static readonly string LogFile="logs/app.log";
public static void Info(string message){
Directory.CreateDirectory("logs");
File.AppendAllText(LogFile,$"[{DateTime.Now:HH:mm:ss}] {message}\n");
}}