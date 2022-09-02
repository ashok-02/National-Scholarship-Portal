using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Institutes",
                columns: table => new
                {
                    InstituteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InstituteCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstituteName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstituteCode = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DiseCode = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstituteType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AffliatedUniversityState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AffliatedUniversityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YearOfAddmission = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressDistrict = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressPincode = table.Column<int>(type: "int", nullable: false),
                    PrincipalName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovedByOfficer = table.Column<bool>(type: "bit", nullable: false),
                    ApprovedByMinistry = table.Column<bool>(type: "bit", nullable: false),
                    IsRejected = table.Column<bool>(type: "bit", nullable: false),
                    RegistrationCertificate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UniversityAffliationCertificate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Institutes", x => x.InstituteId);
                });

            migrationBuilder.CreateTable(
                name: "Ministries",
                columns: table => new
                {
                    MinistryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MinistryEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ministries", x => x.MinistryId);
                });

            migrationBuilder.CreateTable(
                name: "NodalOfficers",
                columns: table => new
                {
                    OfficerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OfficerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OfficerEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NodalOfficers", x => x.OfficerId);
                });

            migrationBuilder.CreateTable(
                name: "ScholarshipSchemes",
                columns: table => new
                {
                    SchemeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScholarshipSchemes", x => x.SchemeId);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstituteCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNo = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    StateOfDomicile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AadharNumber = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BankIfscCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BankAccountNumber = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BankName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    InstituteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_Students_Institutes_InstituteId",
                        column: x => x.InstituteId,
                        principalTable: "Institutes",
                        principalColumn: "InstituteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ScholarshipApplications",
                columns: table => new
                {
                    ApplicationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AadharNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Community = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Religion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnnualIncome = table.Column<int>(type: "int", nullable: false),
                    InstituteName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PresentCourse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PresentCourseYear = table.Column<int>(type: "int", nullable: false),
                    ModeOfStudy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClassStartDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UniversityBoardName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreviousCourse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreviousPassingYear = table.Column<int>(type: "int", nullable: false),
                    PreviousClassPercentage = table.Column<int>(type: "int", nullable: false),
                    RollNo10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoardName10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PassingYear10 = table.Column<int>(type: "int", nullable: false),
                    Percentage10 = table.Column<int>(type: "int", nullable: false),
                    RollNo12 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoardName12 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PassingYear12 = table.Column<int>(type: "int", nullable: false),
                    Percentage12 = table.Column<int>(type: "int", nullable: false),
                    AddmissionFee = table.Column<int>(type: "int", nullable: false),
                    TutionFee = table.Column<int>(type: "int", nullable: false),
                    OtherFee = table.Column<int>(type: "int", nullable: false),
                    IsDisabled = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeOfDisability = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PercentageDisability = table.Column<int>(type: "int", nullable: false),
                    MartialStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentProfession = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Block = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HouseNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StreetNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pincode = table.Column<int>(type: "int", nullable: false),
                    ApprovedByInstitute = table.Column<bool>(type: "bit", nullable: false),
                    ApprovedByOfficer = table.Column<bool>(type: "bit", nullable: false),
                    ApprovedByMinistry = table.Column<bool>(type: "bit", nullable: false),
                    InstituteCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsRejected = table.Column<bool>(type: "bit", nullable: false),
                    DomicileCertificate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstituteIdCard = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CasteOrIncomeCertificate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreviousYearMarksheet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeeReceiptOfCurrentYear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BankPassBook = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AadharCard = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MarkSheet10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MarkSheet12 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SchemeId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScholarshipApplications", x => x.ApplicationId);
                    table.ForeignKey(
                        name: "FK_ScholarshipApplications_ScholarshipSchemes_SchemeId",
                        column: x => x.SchemeId,
                        principalTable: "ScholarshipSchemes",
                        principalColumn: "SchemeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ScholarshipApplications_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Ministries",
                columns: new[] { "MinistryId", "MinistryEmail", "Name", "PasswordHash", "PasswordSalt" },
                values: new object[] { 1, "ministry@nsp.com", "Ministry", new byte[] { 81, 210, 13, 101, 7, 116, 28, 182, 60, 38, 25, 239, 239, 98, 66, 72, 212, 124, 84, 238, 178, 153, 147, 112, 5, 205, 175, 219, 231, 25, 106, 128, 46, 196, 32, 63, 23, 15, 101, 219, 21, 132, 218, 52, 78, 23, 157, 170, 217, 241, 178, 214, 104, 57, 110, 54, 240, 154, 102, 129, 136, 99, 174, 254 }, new byte[] { 247, 156, 160, 226, 28, 144, 29, 143, 91, 236, 198, 101, 212, 188, 213, 168, 103, 94, 22, 150, 70, 131, 164, 64, 54, 118, 133, 96, 70, 29, 149, 21, 182, 96, 39, 240, 160, 102, 60, 148, 200, 107, 125, 82, 62, 220, 153, 123, 124, 71, 92, 177, 58, 84, 40, 203, 240, 46, 188, 128, 32, 136, 122, 107, 4, 226, 83, 66, 7, 195, 234, 164, 135, 242, 206, 0, 176, 31, 135, 204, 154, 27, 130, 35, 61, 242, 190, 121, 12, 237, 170, 227, 104, 211, 86, 180, 153, 139, 163, 58, 141, 225, 116, 171, 14, 50, 182, 51, 210, 27, 217, 237, 231, 145, 109, 129, 118, 15, 59, 200, 24, 139, 193, 86, 23, 106, 45, 139 } });

            migrationBuilder.InsertData(
                table: "NodalOfficers",
                columns: new[] { "OfficerId", "OfficerEmail", "OfficerName", "PasswordHash", "PasswordSalt" },
                values: new object[] { 1, "officer@nsp.com", "Officer", new byte[] { 4, 68, 108, 223, 154, 109, 251, 213, 94, 123, 178, 74, 44, 19, 133, 87, 222, 177, 75, 89, 151, 99, 158, 0, 227, 208, 215, 112, 173, 152, 128, 102, 208, 45, 118, 184, 249, 139, 227, 71, 120, 231, 50, 168, 50, 185, 198, 195, 107, 86, 19, 197, 205, 240, 50, 228, 183, 91, 200, 63, 123, 234, 1, 97 }, new byte[] { 53, 150, 76, 167, 152, 244, 97, 17, 45, 122, 155, 95, 85, 213, 63, 229, 241, 203, 51, 124, 50, 68, 135, 47, 198, 246, 227, 218, 36, 6, 190, 137, 35, 251, 60, 100, 11, 86, 248, 190, 54, 51, 154, 215, 10, 196, 160, 86, 207, 79, 109, 165, 199, 231, 80, 172, 15, 144, 150, 134, 235, 161, 30, 79, 224, 67, 26, 7, 68, 1, 33, 84, 54, 197, 217, 233, 227, 236, 78, 227, 159, 129, 208, 127, 71, 164, 124, 96, 105, 179, 86, 224, 127, 161, 52, 8, 191, 198, 139, 119, 148, 71, 29, 63, 53, 37, 254, 124, 162, 210, 28, 216, 73, 241, 167, 109, 55, 138, 125, 0, 254, 96, 42, 154, 253, 2, 143, 97 } });

            migrationBuilder.CreateIndex(
                name: "IX_Institutes_DiseCode_InstituteCode",
                table: "Institutes",
                columns: new[] { "DiseCode", "InstituteCode" },
                unique: true,
                filter: "[DiseCode] IS NOT NULL AND [InstituteCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ScholarshipApplications_SchemeId",
                table: "ScholarshipApplications",
                column: "SchemeId");

            migrationBuilder.CreateIndex(
                name: "IX_ScholarshipApplications_StudentId",
                table: "ScholarshipApplications",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_AadharNumber_PhoneNo_BankAccountNumber",
                table: "Students",
                columns: new[] { "AadharNumber", "PhoneNo", "BankAccountNumber" },
                unique: true,
                filter: "[AadharNumber] IS NOT NULL AND [PhoneNo] IS NOT NULL AND [BankAccountNumber] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Students_InstituteId",
                table: "Students",
                column: "InstituteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ministries");

            migrationBuilder.DropTable(
                name: "NodalOfficers");

            migrationBuilder.DropTable(
                name: "ScholarshipApplications");

            migrationBuilder.DropTable(
                name: "ScholarshipSchemes");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Institutes");
        }
    }
}
