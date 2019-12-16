namespace BizTalk.ESBPortal.Reader
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EsbExceptionsDb : DbContext
    {
        public EsbExceptionsDb()
            : base("name=EsbExceptionsModel")
        {
        }

        public virtual DbSet<ActionType> ActionType { get; set; }
        public virtual DbSet<Alert> Alert { get; set; }
        public virtual DbSet<AlertCondition> AlertCondition { get; set; }
        public virtual DbSet<AlertEmail> AlertEmail { get; set; }
        public virtual DbSet<AlertHistory> AlertHistory { get; set; }
        public virtual DbSet<AlertSubscription> AlertSubscription { get; set; }
        public virtual DbSet<AlertSubscriptionHistory> AlertSubscriptionHistory { get; set; }
        public virtual DbSet<AuditLog> AuditLog { get; set; }
        public virtual DbSet<AuditLogMessageData> AuditLogMessageData { get; set; }
        public virtual DbSet<Batch> Batch { get; set; }
        public virtual DbSet<Configuration> Configuration { get; set; }
        public virtual DbSet<ContextProperty> ContextProperty { get; set; }
        public virtual DbSet<Fault> Fault { get; set; }
        public virtual DbSet<Message> Message { get; set; }
        public virtual DbSet<MessageData> MessageData { get; set; }
        public virtual DbSet<ProcessedFault> ProcessedFault { get; set; }
        public virtual DbSet<UserSetting> UserSetting { get; set; }
        public virtual DbSet<vw_AggregatedFaults> vw_AggregatedFaults { get; set; }
        public virtual DbSet<vwFaultMessageInfo> vwFaultMessageInfo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActionType>()
                .Property(e => e.ActionName)
                .IsUnicode(false);

            modelBuilder.Entity<Alert>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Alert>()
                .Property(e => e.ConditionsString)
                .IsUnicode(false);

            modelBuilder.Entity<Alert>()
                .Property(e => e.InsertedBy)
                .IsUnicode(false);

            modelBuilder.Entity<AlertCondition>()
                .Property(e => e.LeftSide)
                .IsUnicode(false);

            modelBuilder.Entity<AlertCondition>()
                .Property(e => e.RightSide)
                .IsUnicode(false);

            modelBuilder.Entity<AlertCondition>()
                .Property(e => e.Operator)
                .IsUnicode(false);

            modelBuilder.Entity<AlertEmail>()
                .Property(e => e.To)
                .IsUnicode(false);

            modelBuilder.Entity<AlertEmail>()
                .Property(e => e.Subject)
                .IsUnicode(false);

            modelBuilder.Entity<AlertEmail>()
                .Property(e => e.Body)
                .IsUnicode(false);

            modelBuilder.Entity<AlertHistory>()
                .Property(e => e.AlertName)
                .IsUnicode(false);

            modelBuilder.Entity<AlertHistory>()
                .Property(e => e.Application)
                .IsUnicode(false);

            modelBuilder.Entity<AlertHistory>()
                .Property(e => e.ServiceName)
                .IsUnicode(false);

            modelBuilder.Entity<AlertHistory>()
                .HasMany(e => e.AlertSubscriptionHistory)
                .WithRequired(e => e.AlertHistory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AlertSubscription>()
                .Property(e => e.Subscriber)
                .IsUnicode(false);

            modelBuilder.Entity<AlertSubscription>()
                .Property(e => e.CustomEmail)
                .IsUnicode(false);

            modelBuilder.Entity<AlertSubscription>()
                .Property(e => e.InsertedBy)
                .IsUnicode(false);

            modelBuilder.Entity<AlertSubscription>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<AlertSubscriptionHistory>()
                .Property(e => e.Subscriber)
                .IsUnicode(false);

            modelBuilder.Entity<AlertSubscriptionHistory>()
                .Property(e => e.CustomEmail)
                .IsUnicode(false);

            modelBuilder.Entity<AuditLog>()
                .Property(e => e.NativeMessageID)
                .IsUnicode(false);

            modelBuilder.Entity<AuditLog>()
                .Property(e => e.ContentType)
                .IsUnicode(false);

            modelBuilder.Entity<AuditLog>()
                .Property(e => e.MessageName)
                .IsUnicode(false);

            modelBuilder.Entity<AuditLog>()
                .Property(e => e.NativeFaultID)
                .IsUnicode(false);

            modelBuilder.Entity<AuditLog>()
                .Property(e => e.Application)
                .IsUnicode(false);

            modelBuilder.Entity<AuditLog>()
                .Property(e => e.ServiceName)
                .IsUnicode(false);

            modelBuilder.Entity<AuditLog>()
                .Property(e => e.ResubmitURL)
                .IsUnicode(false);

            modelBuilder.Entity<AuditLog>()
                .Property(e => e.ResubmitCode)
                .IsUnicode(false);

            modelBuilder.Entity<AuditLog>()
                .Property(e => e.ResubmitMessage)
                .IsUnicode(false);

            modelBuilder.Entity<AuditLog>()
                .Property(e => e.AuditUserName)
                .IsUnicode(false);

            modelBuilder.Entity<AuditLogMessageData>()
                .Property(e => e.MessageData)
                .IsUnicode(false);

            modelBuilder.Entity<Batch>()
                .Property(e => e.ErrorMessage)
                .IsUnicode(false);

            modelBuilder.Entity<Configuration>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Configuration>()
                .Property(e => e.Value)
                .IsUnicode(false);

            modelBuilder.Entity<Configuration>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Configuration>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<ContextProperty>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<ContextProperty>()
                .Property(e => e.Value)
                .IsUnicode(false);

            modelBuilder.Entity<ContextProperty>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<Fault>()
                .Property(e => e.NativeMessageID)
                .IsUnicode(false);

            modelBuilder.Entity<Fault>()
                .Property(e => e.ActivityID)
                .IsUnicode(false);

            modelBuilder.Entity<Fault>()
                .Property(e => e.Application)
                .IsUnicode(false);

            modelBuilder.Entity<Fault>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Fault>()
                .Property(e => e.ErrorType)
                .IsUnicode(false);

            modelBuilder.Entity<Fault>()
                .Property(e => e.FailureCategory)
                .IsUnicode(false);

            modelBuilder.Entity<Fault>()
                .Property(e => e.FaultCode)
                .IsUnicode(false);

            modelBuilder.Entity<Fault>()
                .Property(e => e.FaultDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Fault>()
                .Property(e => e.Scope)
                .IsUnicode(false);

            modelBuilder.Entity<Fault>()
                .Property(e => e.ServiceInstanceID)
                .IsUnicode(false);

            modelBuilder.Entity<Fault>()
                .Property(e => e.ServiceName)
                .IsUnicode(false);

            modelBuilder.Entity<Fault>()
                .Property(e => e.FaultGenerator)
                .IsUnicode(false);

            modelBuilder.Entity<Fault>()
                .Property(e => e.MachineName)
                .IsUnicode(false);

            modelBuilder.Entity<Fault>()
                .Property(e => e.ExceptionMessage)
                .IsUnicode(false);

            modelBuilder.Entity<Fault>()
                .Property(e => e.ExceptionType)
                .IsUnicode(false);

            modelBuilder.Entity<Fault>()
                .Property(e => e.ExceptionSource)
                .IsUnicode(false);

            modelBuilder.Entity<Fault>()
                .Property(e => e.ExceptionTargetSite)
                .IsUnicode(false);

            modelBuilder.Entity<Fault>()
                .Property(e => e.ExceptionStackTrace)
                .IsUnicode(false);

            modelBuilder.Entity<Fault>()
                .Property(e => e.InnerExceptionMessage)
                .IsUnicode(false);

            modelBuilder.Entity<Message>()
                .Property(e => e.NativeMessageID)
                .IsUnicode(false);

            modelBuilder.Entity<Message>()
                .Property(e => e.ContentType)
                .IsUnicode(false);

            modelBuilder.Entity<Message>()
                .Property(e => e.MessageName)
                .IsUnicode(false);

            modelBuilder.Entity<Message>()
                .Property(e => e.InterchangeID)
                .IsUnicode(false);

            modelBuilder.Entity<Message>()
                .Property(e => e.RoutingUrl)
                .IsUnicode(false);

            modelBuilder.Entity<Message>()
                .Property(e => e.ActivityID)
                .IsUnicode(false);

            modelBuilder.Entity<MessageData>()
                .Property(e => e.MessageData1)
                .IsUnicode(false);

            modelBuilder.Entity<UserSetting>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<UserSetting>()
                .Property(e => e.SettingName)
                .IsUnicode(false);

            modelBuilder.Entity<UserSetting>()
                .Property(e => e.SettingValue)
                .IsUnicode(false);

            modelBuilder.Entity<vw_AggregatedFaults>()
                .Property(e => e.Application)
                .IsUnicode(false);

            modelBuilder.Entity<vw_AggregatedFaults>()
                .Property(e => e.ServiceName)
                .IsUnicode(false);

            modelBuilder.Entity<vw_AggregatedFaults>()
                .Property(e => e.ErrorType)
                .IsUnicode(false);

            modelBuilder.Entity<vw_AggregatedFaults>()
                .Property(e => e.ExceptionType)
                .IsUnicode(false);

            modelBuilder.Entity<vw_AggregatedFaults>()
                .Property(e => e.FaultCode)
                .IsUnicode(false);

            modelBuilder.Entity<vw_AggregatedFaults>()
                .Property(e => e.FailureCategory)
                .IsUnicode(false);

            modelBuilder.Entity<vwFaultMessageInfo>()
                .Property(e => e.ContentType)
                .IsUnicode(false);

            modelBuilder.Entity<vwFaultMessageInfo>()
                .Property(e => e.MessageName)
                .IsUnicode(false);

            modelBuilder.Entity<vwFaultMessageInfo>()
                .Property(e => e.InterchangeID)
                .IsUnicode(false);

            modelBuilder.Entity<vwFaultMessageInfo>()
                .Property(e => e.RoutingUrl)
                .IsUnicode(false);

            modelBuilder.Entity<vwFaultMessageInfo>()
                .Property(e => e.ActivityID)
                .IsUnicode(false);

            modelBuilder.Entity<vwFaultMessageInfo>()
                .Property(e => e.NativeMessageID)
                .IsUnicode(false);

            modelBuilder.Entity<vwFaultMessageInfo>()
                .Property(e => e.Application)
                .IsUnicode(false);

            modelBuilder.Entity<vwFaultMessageInfo>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<vwFaultMessageInfo>()
                .Property(e => e.ErrorType)
                .IsUnicode(false);

            modelBuilder.Entity<vwFaultMessageInfo>()
                .Property(e => e.FailureCategory)
                .IsUnicode(false);

            modelBuilder.Entity<vwFaultMessageInfo>()
                .Property(e => e.FaultCode)
                .IsUnicode(false);

            modelBuilder.Entity<vwFaultMessageInfo>()
                .Property(e => e.FaultDescription)
                .IsUnicode(false);

            modelBuilder.Entity<vwFaultMessageInfo>()
                .Property(e => e.Scope)
                .IsUnicode(false);

            modelBuilder.Entity<vwFaultMessageInfo>()
                .Property(e => e.ServiceInstanceID)
                .IsUnicode(false);

            modelBuilder.Entity<vwFaultMessageInfo>()
                .Property(e => e.ServiceName)
                .IsUnicode(false);

            modelBuilder.Entity<vwFaultMessageInfo>()
                .Property(e => e.FaultGenerator)
                .IsUnicode(false);

            modelBuilder.Entity<vwFaultMessageInfo>()
                .Property(e => e.MachineName)
                .IsUnicode(false);

            modelBuilder.Entity<vwFaultMessageInfo>()
                .Property(e => e.ExceptionMessage)
                .IsUnicode(false);

            modelBuilder.Entity<vwFaultMessageInfo>()
                .Property(e => e.ExceptionType)
                .IsUnicode(false);

            modelBuilder.Entity<vwFaultMessageInfo>()
                .Property(e => e.ExceptionSource)
                .IsUnicode(false);

            modelBuilder.Entity<vwFaultMessageInfo>()
                .Property(e => e.ExceptionTargetSite)
                .IsUnicode(false);

            modelBuilder.Entity<vwFaultMessageInfo>()
                .Property(e => e.ExceptionStackTrace)
                .IsUnicode(false);

            modelBuilder.Entity<vwFaultMessageInfo>()
                .Property(e => e.InnerExceptionMessage)
                .IsUnicode(false);

            modelBuilder.Entity<vwFaultMessageInfo>()
                .Property(e => e.MessageData)
                .IsUnicode(false);
        }
    }
}
