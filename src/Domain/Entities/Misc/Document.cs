﻿using WarehouseManger.Domain.Contracts;
using WarehouseManger.Domain.Entities.ExtendedAttributes;

namespace WarehouseManger.Domain.Entities.Misc
{
    public class Document : AuditableEntityWithExtendedAttributes<int, int, Document, DocumentExtendedAttribute>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsPublic { get; set; } = false;
        public string URL { get; set; }
        public int DocumentTypeId { get; set; }
        public virtual DocumentType DocumentType { get; set; }
    }
}