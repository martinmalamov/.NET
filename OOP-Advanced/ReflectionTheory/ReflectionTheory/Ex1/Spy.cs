using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

class Spy
{

    public string CollectGettersAndSetters(string investigatedClass)
    {
        Type typeOfClass = Type.GetType(investigatedClass);
        MethodInfo[] methodInfos = typeOfClass.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
        StringBuilder stringBuilder = new StringBuilder();

        foreach (MethodInfo method in methodInfos.Where(x => x.Name.StartsWith("get")))
        {
            stringBuilder.AppendLine($"{method.Name} will return {method.ReturnType}");
        }
        foreach (MethodInfo method in methodInfos.Where(x=> x.Name.StartsWith("set")))
        {
            stringBuilder.AppendLine($"{method.Name} will set field of {method.GetParameters().First().ParameterType}");
        }

        return stringBuilder.ToString().Trim();
    }





    public string StealFieldInfo(string investigatedClass, params string[] requestedFields)
    {

        Type classType = Type.GetType(investigatedClass);
        FieldInfo[] classFields = classType.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic
            | BindingFlags.Public);
        StringBuilder stringBuilder = new StringBuilder();

        Object classInstance = Activator.CreateInstance(classType,new object[] { });

        stringBuilder.AppendLine($"Class under investigation: {investigatedClass}");

        foreach (FieldInfo field in classFields.Where(f => requestedFields.Contains(f.Name)))
        {
            stringBuilder.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
        }

        return stringBuilder.ToString().Trim();
    }

    public string AnalyzeAcessModifiers(string investigatedClass)
    {
        Type classType = Type.GetType(investigatedClass);

        FieldInfo[] classFields = classType.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static);
        MethodInfo[] classPublicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.Public);
        MethodInfo[] classNonPublicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

        StringBuilder stringBuilder = new StringBuilder();

        foreach  (FieldInfo field in classFields)
        {
            stringBuilder.AppendLine($"{field.Name} must be private!");
        }
        foreach (MethodInfo method in classPublicMethods.Where(x => x.Name.StartsWith("get")))
        {
            stringBuilder.AppendLine($"{method.Name} have to be private!");
        }
        foreach (MethodInfo method in classNonPublicMethods.Where(x => x.Name.StartsWith("set")))
        {
            stringBuilder.AppendLine($"{method.Name} have to be public");
        }

        return stringBuilder.ToString().Trim();
    }

    public string RevealPrivateMethods(string className)
    {
        Type typeofClass = Type.GetType(className);

        MethodInfo[] methodInfos = typeofClass.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
        StringBuilder stringBuilder = new StringBuilder();

        stringBuilder.AppendLine($"All Private Methods of Class: {className}");
        stringBuilder.AppendLine($"Base Class: {typeofClass.BaseType.Name}");

        foreach (MethodInfo method in methodInfos)
        {
            stringBuilder.AppendLine(method.Name);
        }
        return stringBuilder.ToString().Trim();
    }
}

