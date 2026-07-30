using System.Collections.Generic;
using System.Linq;
namespace ModManager.Mewgenics.Core;
public sealed class ProfileManager{
private readonly List<string> _profiles=new();
public IReadOnlyList<string> Profiles=>_profiles;
public bool Add(string name){
if(string.IsNullOrWhiteSpace(name)||_profiles.Contains(name)) return false;
_profiles.Add(name); return true;}
public bool Remove(string name)=>_profiles.Remove(name);
}