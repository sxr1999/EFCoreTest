// See https://aka.ms/new-console-template for more information

using EFCoreTest;
using Microsoft.EntityFrameworkCore;
using System.Text;

OrgUnit parent = new OrgUnit()
{
    Name = "全球总部"
};

OrgUnit child1 = new OrgUnit()
{
    Name = "亚太总部"
};

OrgUnit child2 = new OrgUnit()
{
    Name = "北美总部"
};
OrgUnit child11 = new OrgUnit()
{
    Name = "中国"
};

OrgUnit child12 = new OrgUnit()
{
    Name = "日本"
};

OrgUnit child21 = new OrgUnit()
{
    Name = "美国"
};
OrgUnit child22 = new OrgUnit()
{
    Name = "加拿大"
};

child1.Parent = parent;
child2.Parent = parent;
    

child11.Parent = child1;
child12.Parent = child1;
child21.Parent = child2;
child22.Parent = child2;
// Console.WriteLine("Hello, World!");
//
// Person person = new Person()
// {
//     Name = "Zhangsan",
//     Age = 23,
// };
//
// Person person1 = new Person()
// {
//     Name = "Lisi",
//     Age = 18
// };

using (TestDbContext dbContext = new TestDbContext())
{
    // //var rseult = dbContext.Persons.Where(a => a.Name.Equals("Lisi")).FirstOrDefault();
    //  var result = dbContext.Persons.Where(a => a.BrithDay.Year == 1998).Take(3);
    //  foreach (var item in result)
    //  {
    //      Console.WriteLine(item);
    //  }
    // //Console.WriteLine(result.ToQueryString());
    //
    // dbContext.Persons.Add(person1);
    //
    // Article article = new Article()
    // {
    //     Title = "时间简史",
    //     Message = "时间简史内容书籍"
    // };
    //
    // Commont commont = new Commont()
    // {
    //     Name = "张三",
    //     Message = "书真好看"
    // };
    //
    // Commont commont2 = new Commont()
    // {
    //     Name = "李四",
    //     Message = "书不好看"
    // };
    // article.Commonts.Add(commont);
    // article.Commonts.Add(commont2); 
    // dbContext.Articles.Add(article);
    // dbContext.SaveChanges();
    // User user1 = new User()
    // {
    //     Name = "张三"
    // };
    // User user2 = new User()
    // {
    //     Name = "李四"
    // };
    //
    // Leave leave = new Leave();
    // leave.Approver = user1;
    // leave.Requester = user2;
    // leave.Time = DateTime.Now;
    // dbContext.Leaves.Add(leave);
    // await dbContext.SaveChangesAsync();






    //dbContext.OrgUnits.Add(parent);
    //dbContext.OrgUnits.Add(child1);

    //dbContext.OrgUnits.Add(child11);
    //dbContext.OrgUnits.Add(child12);

    //dbContext.OrgUnits.Add(child2);
    //dbContext.OrgUnits.Add(child21);
    //dbContext.OrgUnits.Add(child22);
    //dbContext.SaveChanges();

    var a = dbContext.OrgUnits.Where(x => x.Parent == null).FirstOrDefault();
    Console.OutputEncoding = Encoding.GetEncoding(936);
    Console.WriteLine(a.Name);
    Method.PrintChildren(1, dbContext, a);

}