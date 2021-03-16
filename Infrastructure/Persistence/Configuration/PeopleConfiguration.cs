using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Persistence.Configuration
{
    public class PeopleConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasKey(e => e.BusinessEntityId)
                    .HasName("PK_Person_BusinessEntityID");

            builder.ToTable("Person", "Person");

            builder.HasComment("Human beings involved with AdventureWorks: employees, customer contacts, and vendor contacts.");

            builder.HasIndex(e => e.Rowguid, "AK_Person_rowguid")
                .IsUnique();

            builder.HasIndex(e => new { e.LastName, e.FirstName, e.MiddleName }, "IX_Person_LastName_FirstName_MiddleName");

            builder.HasIndex(e => e.AdditionalContactInfo, "PXML_Person_AddContact");

            builder.HasIndex(e => e.Demographics, "PXML_Person_Demographics");

            builder.HasIndex(e => e.Demographics, "XMLPATH_Person_Demographics");

            builder.HasIndex(e => e.Demographics, "XMLPROPERTY_Person_Demographics");

            builder.HasIndex(e => e.Demographics, "XMLVALUE_Person_Demographics");

            builder.Property(e => e.BusinessEntityId)
                .ValueGeneratedNever()
                .HasColumnName("BusinessEntityID")
                .HasComment("Primary key for Person records.");

            builder.Property(e => e.AdditionalContactInfo)
                .HasColumnType("xml")
                .HasComment("Additional contact information about the person stored in xml format. ");

            builder.Property(e => e.Demographics)
                .HasColumnType("xml")
                .HasComment("Personal information such as hobbies, and income collected from online shoppers. Used for sales analysis.");

            builder.Property(e => e.EmailPromotion).HasComment("0 = Contact does not wish to receive e-mail promotions, 1 = Contact does wish to receive e-mail promotions from AdventureWorks, 2 = Contact does wish to receive e-mail promotions from AdventureWorks and selected partners. ");

            builder.Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(50)
                .HasComment("First name of the person.");

            builder.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(50)
                .HasComment("Last name of the person.");

            builder.Property(e => e.MiddleName)
                .HasMaxLength(50)
                .HasComment("Middle name or middle initial of the person.");

            builder.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.");

            builder.Property(e => e.NameStyle).HasComment("0 = The data in FirstName and LastName are stored in western style (first name, last name) order.  1 = Eastern style (last name, first name) order.");

            builder.Property(e => e.PersonType)
                .IsRequired()
                .HasMaxLength(2)
                .IsFixedLength(true)
                .HasComment("Primary type of person: SC = Store Contact, IN = Individual (retail) customer, SP = Sales person, EM = Employee (non-sales), VC = Vendor contact, GC = General contact");

            builder.Property(e => e.Rowguid)
                .HasColumnName("rowguid")
                .HasDefaultValueSql("(newid())")
                .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

            builder.Property(e => e.Suffix)
                .HasMaxLength(10)
                .HasComment("Surname suffix. For example, Sr. or Jr.");

            builder.Property(e => e.Title)
                .HasMaxLength(8)
                .HasComment("A courtesy title. For example, Mr. or Ms.");
        }
    }
}
