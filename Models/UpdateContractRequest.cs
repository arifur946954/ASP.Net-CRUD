﻿namespace ContractApi.Models
{
    public class UpdateContractRequest
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
      
    }
}
