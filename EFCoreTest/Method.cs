namespace EFCoreTest;

public static class Method
{
    public static void PrintChildren(int a, TestDbContext ctx, OrgUnit parent)
    {
        var child = ctx.OrgUnits.Where(x => x.Parent == parent).ToList();

       
            foreach (var item in child)
            {
                Console.WriteLine(new string('\t', a) + item.Name);
                PrintChildren(a + 1, ctx, item);
            }
        
    }
}