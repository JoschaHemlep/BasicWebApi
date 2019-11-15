using BasicWebApi.Dtos;
using Reinforced.Typings.Ast.TypeNames;
using Reinforced.Typings.Fluent;
using System.Linq;
using System.Reflection;

namespace BasicWebApi.ReinforcedTypings
{
    public static class ReinforcedTypingsConfiguration
    {
        public static void Configure(ConfigurationBuilder builder)
        {
            var types = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(_ => _.Namespace.StartsWith(typeof(ExampleDto).Namespace));

            var classTypes = types.Where(_ => _.IsClass);
            var enumTypes = types.Where(_ => _.IsEnum);

            builder.Global(_ => _.UnresolvedToUnknown());

            builder.ExportAsInterfaces(classTypes, _ => _
                .AutoI(false)
                .WithPublicProperties()
                .Substitute(typeof(System.DateTime), new RtSimpleTypeName("Date"))
            );

            builder.ExportAsEnums(enumTypes);
        }
    }
}