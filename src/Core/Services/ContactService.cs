using CrmApp.Core.Entities;
using CrmApp.Infrastructure.Data;
using CrmApp.Models.Requests;
using FluentValidation;

namespace CrmApp.Core.Services;

public class ContactService
{
    private readonly ApplicationDbContext _context;

    public ContactService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Contact> CreateContactAsync(ContactRequest request)
    {
        if (!request.IsValid(out var validationErrors))
        {
            throw new ValidationException(validationErrors);
        }

        var contact = request.ToContact();
        _context.Contacts.Add(contact);
        await _context.SaveChangesAsync();
        return contact;
    }
}
