namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c9caed37-0cf3-4b59-abe4-12aafedde8a1', N'guest@vidly.com', 0, N'ADBEmVomSXHLq9z6JgjkZmNgEhzyEy/3alyxJO6L3zhjYQ7sYWgzZD2bEIuU9qt2LQ==', N'23490826-9960-4314-8569-d10dad25b046', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e810326c-d5bd-4afb-8a1d-e146d985b50e', N'admin@vidly.com', 0, N'AEFUJzLd4COkUT7KqyzsJfXCrXTmcSf7W55Br+L/wyKPfKdIP30dA+rcGfpx5yJp5w==', N'b81551df-a3db-466e-979f-107176d6835e', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'c7d2513b-14f2-44eb-aef3-7426dae7ce1c', N'CanManageMovies')

                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'e810326c-d5bd-4afb-8a1d-e146d985b50e', N'c7d2513b-14f2-44eb-aef3-7426dae7ce1c')

                ");
        }
        
        public override void Down()
        {
        }
    }
}
