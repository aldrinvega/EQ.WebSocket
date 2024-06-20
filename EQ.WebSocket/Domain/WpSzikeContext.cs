using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EQ.WebSocket.Domain;

public partial class WpSzikeContext : DbContext
{
    public WpSzikeContext()
    {
    }

    public WpSzikeContext(DbContextOptions<WpSzikeContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Yv5w6h8fActionschedulerAction> Yv5w6h8fActionschedulerActions { get; set; }

    public virtual DbSet<Yv5w6h8fActionschedulerClaim> Yv5w6h8fActionschedulerClaims { get; set; }

    public virtual DbSet<Yv5w6h8fActionschedulerGroup> Yv5w6h8fActionschedulerGroups { get; set; }

    public virtual DbSet<Yv5w6h8fActionschedulerLog> Yv5w6h8fActionschedulerLogs { get; set; }

    public virtual DbSet<Yv5w6h8fComment> Yv5w6h8fComments { get; set; }

    public virtual DbSet<Yv5w6h8fCommentmetum> Yv5w6h8fCommentmeta { get; set; }

    public virtual DbSet<Yv5w6h8fEEvent> Yv5w6h8fEEvents { get; set; }

    public virtual DbSet<Yv5w6h8fENote> Yv5w6h8fENotes { get; set; }

    public virtual DbSet<Yv5w6h8fENotesUsersRelation> Yv5w6h8fENotesUsersRelations { get; set; }

    public virtual DbSet<Yv5w6h8fESubmission> Yv5w6h8fESubmissions { get; set; }

    public virtual DbSet<Yv5w6h8fESubmissionsActionsLog> Yv5w6h8fESubmissionsActionsLogs { get; set; }

    public virtual DbSet<Yv5w6h8fESubmissionsValue> Yv5w6h8fESubmissionsValues { get; set; }

    public virtual DbSet<Yv5w6h8fLink> Yv5w6h8fLinks { get; set; }

    public virtual DbSet<Yv5w6h8fLitespeedUrl> Yv5w6h8fLitespeedUrls { get; set; }

    public virtual DbSet<Yv5w6h8fLitespeedUrlFile> Yv5w6h8fLitespeedUrlFiles { get; set; }

    public virtual DbSet<Yv5w6h8fOption> Yv5w6h8fOptions { get; set; }

    public virtual DbSet<Yv5w6h8fPost> Yv5w6h8fPosts { get; set; }

    public virtual DbSet<Yv5w6h8fPostmetum> Yv5w6h8fPostmeta { get; set; }

    public virtual DbSet<Yv5w6h8fSnippet> Yv5w6h8fSnippets { get; set; }

    public virtual DbSet<Yv5w6h8fTerm> Yv5w6h8fTerms { get; set; }

    public virtual DbSet<Yv5w6h8fTermRelationship> Yv5w6h8fTermRelationships { get; set; }

    public virtual DbSet<Yv5w6h8fTermTaxonomy> Yv5w6h8fTermTaxonomies { get; set; }

    public virtual DbSet<Yv5w6h8fTermmetum> Yv5w6h8fTermmeta { get; set; }

    public virtual DbSet<Yv5w6h8fUser> Yv5w6h8fUsers { get; set; }

    public virtual DbSet<Yv5w6h8fUsermetum> Yv5w6h8fUsermeta { get; set; }

    public virtual DbSet<Yv5w6h8fWcAdminNote> Yv5w6h8fWcAdminNotes { get; set; }

    public virtual DbSet<Yv5w6h8fWcAdminNoteAction> Yv5w6h8fWcAdminNoteActions { get; set; }

    public virtual DbSet<Yv5w6h8fWcCategoryLookup> Yv5w6h8fWcCategoryLookups { get; set; }

    public virtual DbSet<Yv5w6h8fWcCustomerLookup> Yv5w6h8fWcCustomerLookups { get; set; }

    public virtual DbSet<Yv5w6h8fWcDownloadLog> Yv5w6h8fWcDownloadLogs { get; set; }

    public virtual DbSet<Yv5w6h8fWcOrder> Yv5w6h8fWcOrders { get; set; }

    public virtual DbSet<Yv5w6h8fWcOrderAddress> Yv5w6h8fWcOrderAddresses { get; set; }

    public virtual DbSet<Yv5w6h8fWcOrderCouponLookup> Yv5w6h8fWcOrderCouponLookups { get; set; }

    public virtual DbSet<Yv5w6h8fWcOrderOperationalDatum> Yv5w6h8fWcOrderOperationalData { get; set; }

    public virtual DbSet<Yv5w6h8fWcOrderProductLookup> Yv5w6h8fWcOrderProductLookups { get; set; }

    public virtual DbSet<Yv5w6h8fWcOrderStat> Yv5w6h8fWcOrderStats { get; set; }

    public virtual DbSet<Yv5w6h8fWcOrderTaxLookup> Yv5w6h8fWcOrderTaxLookups { get; set; }

    public virtual DbSet<Yv5w6h8fWcOrdersMetum> Yv5w6h8fWcOrdersMeta { get; set; }

    public virtual DbSet<Yv5w6h8fWcProductAttributesLookup> Yv5w6h8fWcProductAttributesLookups { get; set; }

    public virtual DbSet<Yv5w6h8fWcProductDownloadDirectory> Yv5w6h8fWcProductDownloadDirectories { get; set; }

    public virtual DbSet<Yv5w6h8fWcProductMetaLookup> Yv5w6h8fWcProductMetaLookups { get; set; }

    public virtual DbSet<Yv5w6h8fWcRateLimit> Yv5w6h8fWcRateLimits { get; set; }

    public virtual DbSet<Yv5w6h8fWcReservedStock> Yv5w6h8fWcReservedStocks { get; set; }

    public virtual DbSet<Yv5w6h8fWcTaxRateClass> Yv5w6h8fWcTaxRateClasses { get; set; }

    public virtual DbSet<Yv5w6h8fWcWebhook> Yv5w6h8fWcWebhooks { get; set; }

    public virtual DbSet<Yv5w6h8fWcfmDailyAnalysis> Yv5w6h8fWcfmDailyAnalyses { get; set; }

    public virtual DbSet<Yv5w6h8fWcfmDetailedAnalysis> Yv5w6h8fWcfmDetailedAnalyses { get; set; }

    public virtual DbSet<Yv5w6h8fWcfmEnquiriesMetum> Yv5w6h8fWcfmEnquiriesMeta { get; set; }

    public virtual DbSet<Yv5w6h8fWcfmEnquiriesResponse> Yv5w6h8fWcfmEnquiriesResponses { get; set; }

    public virtual DbSet<Yv5w6h8fWcfmEnquiriesResponseMetum> Yv5w6h8fWcfmEnquiriesResponseMeta { get; set; }

    public virtual DbSet<Yv5w6h8fWcfmEnquiry> Yv5w6h8fWcfmEnquiries { get; set; }

    public virtual DbSet<Yv5w6h8fWcfmFbcChatRow> Yv5w6h8fWcfmFbcChatRows { get; set; }

    public virtual DbSet<Yv5w6h8fWcfmFbcChatSession> Yv5w6h8fWcfmFbcChatSessions { get; set; }

    public virtual DbSet<Yv5w6h8fWcfmFbcChatVisitor> Yv5w6h8fWcfmFbcChatVisitors { get; set; }

    public virtual DbSet<Yv5w6h8fWcfmFbcOfflineMessage> Yv5w6h8fWcfmFbcOfflineMessages { get; set; }

    public virtual DbSet<Yv5w6h8fWcfmFollowingFollower> Yv5w6h8fWcfmFollowingFollowers { get; set; }

    public virtual DbSet<Yv5w6h8fWcfmMarketplaceOrder> Yv5w6h8fWcfmMarketplaceOrders { get; set; }

    public virtual DbSet<Yv5w6h8fWcfmMarketplaceOrdersMetum> Yv5w6h8fWcfmMarketplaceOrdersMeta { get; set; }

    public virtual DbSet<Yv5w6h8fWcfmMarketplaceProductMultivendor> Yv5w6h8fWcfmMarketplaceProductMultivendors { get; set; }

    public virtual DbSet<Yv5w6h8fWcfmMarketplaceRefundRequest> Yv5w6h8fWcfmMarketplaceRefundRequests { get; set; }

    public virtual DbSet<Yv5w6h8fWcfmMarketplaceRefundRequestMetum> Yv5w6h8fWcfmMarketplaceRefundRequestMeta { get; set; }

    public virtual DbSet<Yv5w6h8fWcfmMarketplaceReverseWithdrawal> Yv5w6h8fWcfmMarketplaceReverseWithdrawals { get; set; }

    public virtual DbSet<Yv5w6h8fWcfmMarketplaceReverseWithdrawalMetum> Yv5w6h8fWcfmMarketplaceReverseWithdrawalMeta { get; set; }

    public virtual DbSet<Yv5w6h8fWcfmMarketplaceReview> Yv5w6h8fWcfmMarketplaceReviews { get; set; }

    public virtual DbSet<Yv5w6h8fWcfmMarketplaceReviewRatingMetum> Yv5w6h8fWcfmMarketplaceReviewRatingMeta { get; set; }

    public virtual DbSet<Yv5w6h8fWcfmMarketplaceReviewsResponse> Yv5w6h8fWcfmMarketplaceReviewsResponses { get; set; }

    public virtual DbSet<Yv5w6h8fWcfmMarketplaceReviewsResponseMetum> Yv5w6h8fWcfmMarketplaceReviewsResponseMeta { get; set; }

    public virtual DbSet<Yv5w6h8fWcfmMarketplaceShippingZoneLocation> Yv5w6h8fWcfmMarketplaceShippingZoneLocations { get; set; }

    public virtual DbSet<Yv5w6h8fWcfmMarketplaceShippingZoneMethod> Yv5w6h8fWcfmMarketplaceShippingZoneMethods { get; set; }

    public virtual DbSet<Yv5w6h8fWcfmMarketplaceStoreTaxonomy> Yv5w6h8fWcfmMarketplaceStoreTaxonomies { get; set; }

    public virtual DbSet<Yv5w6h8fWcfmMarketplaceVendorLedger> Yv5w6h8fWcfmMarketplaceVendorLedgers { get; set; }

    public virtual DbSet<Yv5w6h8fWcfmMarketplaceWithdrawRequest> Yv5w6h8fWcfmMarketplaceWithdrawRequests { get; set; }

    public virtual DbSet<Yv5w6h8fWcfmMarketplaceWithdrawRequestMetum> Yv5w6h8fWcfmMarketplaceWithdrawRequestMeta { get; set; }

    public virtual DbSet<Yv5w6h8fWcfmMembershipSubscription> Yv5w6h8fWcfmMembershipSubscriptions { get; set; }

    public virtual DbSet<Yv5w6h8fWcfmMessage> Yv5w6h8fWcfmMessages { get; set; }

    public virtual DbSet<Yv5w6h8fWcfmMessagesModifier> Yv5w6h8fWcfmMessagesModifiers { get; set; }

    public virtual DbSet<Yv5w6h8fWcfmMessagesStat> Yv5w6h8fWcfmMessagesStats { get; set; }

    public virtual DbSet<Yv5w6h8fWcfmSupport> Yv5w6h8fWcfmSupports { get; set; }

    public virtual DbSet<Yv5w6h8fWcfmSupportMetum> Yv5w6h8fWcfmSupportMeta { get; set; }

    public virtual DbSet<Yv5w6h8fWcfmSupportResponse> Yv5w6h8fWcfmSupportResponses { get; set; }

    public virtual DbSet<Yv5w6h8fWcfmSupportResponseMetum> Yv5w6h8fWcfmSupportResponseMeta { get; set; }

    public virtual DbSet<Yv5w6h8fWoocommerceApiKey> Yv5w6h8fWoocommerceApiKeys { get; set; }

    public virtual DbSet<Yv5w6h8fWoocommerceAttributeTaxonomy> Yv5w6h8fWoocommerceAttributeTaxonomies { get; set; }

    public virtual DbSet<Yv5w6h8fWoocommerceDownloadableProductPermission> Yv5w6h8fWoocommerceDownloadableProductPermissions { get; set; }

    public virtual DbSet<Yv5w6h8fWoocommerceLog> Yv5w6h8fWoocommerceLogs { get; set; }

    public virtual DbSet<Yv5w6h8fWoocommerceOrderItem> Yv5w6h8fWoocommerceOrderItems { get; set; }

    public virtual DbSet<Yv5w6h8fWoocommerceOrderItemmetum> Yv5w6h8fWoocommerceOrderItemmeta { get; set; }

    public virtual DbSet<Yv5w6h8fWoocommercePaymentToken> Yv5w6h8fWoocommercePaymentTokens { get; set; }

    public virtual DbSet<Yv5w6h8fWoocommercePaymentTokenmetum> Yv5w6h8fWoocommercePaymentTokenmeta { get; set; }

    public virtual DbSet<Yv5w6h8fWoocommerceSession> Yv5w6h8fWoocommerceSessions { get; set; }

    public virtual DbSet<Yv5w6h8fWoocommerceShippingZone> Yv5w6h8fWoocommerceShippingZones { get; set; }

    public virtual DbSet<Yv5w6h8fWoocommerceShippingZoneLocation> Yv5w6h8fWoocommerceShippingZoneLocations { get; set; }

    public virtual DbSet<Yv5w6h8fWoocommerceShippingZoneMethod> Yv5w6h8fWoocommerceShippingZoneMethods { get; set; }

    public virtual DbSet<Yv5w6h8fWoocommerceTaxRate> Yv5w6h8fWoocommerceTaxRates { get; set; }

    public virtual DbSet<Yv5w6h8fWoocommerceTaxRateLocation> Yv5w6h8fWoocommerceTaxRateLocations { get; set; }

    public virtual DbSet<Yv5w6h8fWpfFilter> Yv5w6h8fWpfFilters { get; set; }

    public virtual DbSet<Yv5w6h8fWpfMetaKey> Yv5w6h8fWpfMetaKeys { get; set; }

    public virtual DbSet<Yv5w6h8fWpfMetaValue> Yv5w6h8fWpfMetaValues { get; set; }

    public virtual DbSet<Yv5w6h8fWpfMetaValuesBk> Yv5w6h8fWpfMetaValuesBks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySQL("Data Source=184.168.122.205; Port=3306; User Id=kds_net; Password=Fity660?8; Database=wp_szike");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Yv5w6h8fActionschedulerAction>(entity =>
        {
            entity.HasKey(e => e.ActionId).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_actionscheduler_actions");

            entity.HasIndex(e => e.Args, "args");

            entity.HasIndex(e => new { e.ClaimId, e.Status, e.ScheduledDateGmt }, "claim_id_status_scheduled_date_gmt");

            entity.HasIndex(e => e.GroupId, "group_id");

            entity.HasIndex(e => new { e.Hook, e.Status, e.ScheduledDateGmt }, "hook_status_scheduled_date_gmt");

            entity.HasIndex(e => e.LastAttemptGmt, "last_attempt_gmt");

            entity.HasIndex(e => e.ScheduledDateGmt, "scheduled_date_gmt");

            entity.HasIndex(e => new { e.Status, e.ScheduledDateGmt }, "status_scheduled_date_gmt");

            entity.Property(e => e.ActionId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("action_id");
            entity.Property(e => e.Args)
                .HasMaxLength(191)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("args");
            entity.Property(e => e.Attempts)
                .HasColumnType("int(11)")
                .HasColumnName("attempts");
            entity.Property(e => e.ClaimId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("claim_id");
            entity.Property(e => e.ExtendedArgs)
                .HasMaxLength(8000)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("extended_args");
            entity.Property(e => e.GroupId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("group_id");
            entity.Property(e => e.Hook)
                .HasMaxLength(191)
                .HasColumnName("hook");
            entity.Property(e => e.LastAttemptGmt)
                .HasDefaultValueSql("'''0000-00-00 00:00:00'''")
                .HasColumnType("datetime")
                .HasColumnName("last_attempt_gmt");
            entity.Property(e => e.LastAttemptLocal)
                .HasDefaultValueSql("'''0000-00-00 00:00:00'''")
                .HasColumnType("datetime")
                .HasColumnName("last_attempt_local");
            entity.Property(e => e.Priority)
                .HasDefaultValueSql("'10'")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("priority");
            entity.Property(e => e.Schedule)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("schedule");
            entity.Property(e => e.ScheduledDateGmt)
                .HasDefaultValueSql("'''0000-00-00 00:00:00'''")
                .HasColumnType("datetime")
                .HasColumnName("scheduled_date_gmt");
            entity.Property(e => e.ScheduledDateLocal)
                .HasDefaultValueSql("'''0000-00-00 00:00:00'''")
                .HasColumnType("datetime")
                .HasColumnName("scheduled_date_local");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasColumnName("status");
        });

        modelBuilder.Entity<Yv5w6h8fActionschedulerClaim>(entity =>
        {
            entity.HasKey(e => e.ClaimId).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_actionscheduler_claims");

            entity.HasIndex(e => e.DateCreatedGmt, "date_created_gmt");

            entity.Property(e => e.ClaimId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("claim_id");
            entity.Property(e => e.DateCreatedGmt)
                .HasDefaultValueSql("'''0000-00-00 00:00:00'''")
                .HasColumnType("datetime")
                .HasColumnName("date_created_gmt");
        });

        modelBuilder.Entity<Yv5w6h8fActionschedulerGroup>(entity =>
        {
            entity.HasKey(e => e.GroupId).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_actionscheduler_groups");

            entity.HasIndex(e => e.Slug, "slug");

            entity.Property(e => e.GroupId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("group_id");
            entity.Property(e => e.Slug).HasColumnName("slug");
        });

        modelBuilder.Entity<Yv5w6h8fActionschedulerLog>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_actionscheduler_logs");

            entity.HasIndex(e => e.ActionId, "action_id");

            entity.HasIndex(e => e.LogDateGmt, "log_date_gmt");

            entity.Property(e => e.LogId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("log_id");
            entity.Property(e => e.ActionId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("action_id");
            entity.Property(e => e.LogDateGmt)
                .HasDefaultValueSql("'''0000-00-00 00:00:00'''")
                .HasColumnType("datetime")
                .HasColumnName("log_date_gmt");
            entity.Property(e => e.LogDateLocal)
                .HasDefaultValueSql("'''0000-00-00 00:00:00'''")
                .HasColumnType("datetime")
                .HasColumnName("log_date_local");
            entity.Property(e => e.Message)
                .HasColumnType("text")
                .HasColumnName("message");
        });

        modelBuilder.Entity<Yv5w6h8fComment>(entity =>
        {
            entity.HasKey(e => e.CommentId).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_comments");

            entity.HasIndex(e => new { e.CommentApproved, e.CommentDateGmt }, "comment_approved_date_gmt");

            entity.HasIndex(e => e.CommentAuthorEmail, "comment_author_email");

            entity.HasIndex(e => e.CommentDateGmt, "comment_date_gmt");

            entity.HasIndex(e => e.CommentParent, "comment_parent");

            entity.HasIndex(e => e.CommentPostId, "comment_post_ID");

            entity.HasIndex(e => e.CommentType, "woo_idx_comment_type");

            entity.Property(e => e.CommentId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("comment_ID");
            entity.Property(e => e.CommentAgent)
                .HasMaxLength(255)
                .HasDefaultValueSql("''''''")
                .HasColumnName("comment_agent");
            entity.Property(e => e.CommentApproved)
                .HasMaxLength(20)
                .HasDefaultValueSql("'''1'''")
                .HasColumnName("comment_approved");
            entity.Property(e => e.CommentAuthor)
                .HasColumnType("tinytext")
                .HasColumnName("comment_author");
            entity.Property(e => e.CommentAuthorEmail)
                .HasMaxLength(100)
                .HasDefaultValueSql("''''''")
                .HasColumnName("comment_author_email");
            entity.Property(e => e.CommentAuthorIp)
                .HasMaxLength(100)
                .HasDefaultValueSql("''''''")
                .HasColumnName("comment_author_IP");
            entity.Property(e => e.CommentAuthorUrl)
                .HasMaxLength(200)
                .HasDefaultValueSql("''''''")
                .HasColumnName("comment_author_url");
            entity.Property(e => e.CommentContent)
                .HasColumnType("text")
                .HasColumnName("comment_content");
            entity.Property(e => e.CommentDate)
                .HasDefaultValueSql("'''0000-00-00 00:00:00'''")
                .HasColumnType("datetime")
                .HasColumnName("comment_date");
            entity.Property(e => e.CommentDateGmt)
                .HasDefaultValueSql("'''0000-00-00 00:00:00'''")
                .HasColumnType("datetime")
                .HasColumnName("comment_date_gmt");
            entity.Property(e => e.CommentKarma)
                .HasColumnType("int(11)")
                .HasColumnName("comment_karma");
            entity.Property(e => e.CommentParent)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("comment_parent");
            entity.Property(e => e.CommentPostId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("comment_post_ID");
            entity.Property(e => e.CommentType)
                .HasMaxLength(20)
                .HasDefaultValueSql("'''comment'''")
                .HasColumnName("comment_type");
            entity.Property(e => e.UserId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<Yv5w6h8fCommentmetum>(entity =>
        {
            entity.HasKey(e => e.MetaId).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_commentmeta");

            entity.HasIndex(e => e.CommentId, "comment_id");

            entity.HasIndex(e => e.MetaKey, "meta_key");

            entity.Property(e => e.MetaId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("meta_id");
            entity.Property(e => e.CommentId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("comment_id");
            entity.Property(e => e.MetaKey)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("meta_key");
            entity.Property(e => e.MetaValue)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("meta_value");
        });

        modelBuilder.Entity<Yv5w6h8fEEvent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_e_events");

            entity.HasIndex(e => e.CreatedAt, "created_at_index");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.EventData)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("text")
                .HasColumnName("event_data");
        });

        modelBuilder.Entity<Yv5w6h8fENote>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_e_notes");

            entity.HasIndex(e => e.AuthorId, "author_id_index");

            entity.HasIndex(e => e.CreatedAt, "created_at_index");

            entity.HasIndex(e => e.ElementId, "element_id_index");

            entity.HasIndex(e => e.IsPublic, "is_public_index");

            entity.HasIndex(e => e.IsResolved, "is_resolved_index");

            entity.HasIndex(e => e.LastActivityAt, "last_activity_at_index");

            entity.HasIndex(e => e.ParentId, "parent_id_index");

            entity.HasIndex(e => e.PostId, "post_id_index");

            entity.HasIndex(e => e.RouteUrl, "route_url_index");

            entity.HasIndex(e => e.Status, "status_index");

            entity.HasIndex(e => e.UpdatedAt, "updated_at_index");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.AuthorDisplayName)
                .HasMaxLength(250)
                .HasDefaultValueSql("'NULL'")
                .HasComment("Save the author name when the author was deleted.")
                .HasColumnName("author_display_name");
            entity.Property(e => e.AuthorId)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("author_id");
            entity.Property(e => e.Content)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("content");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.ElementId)
                .HasMaxLength(60)
                .HasDefaultValueSql("'NULL'")
                .HasComment("The Elementor element ID the note is attached to.")
                .HasColumnName("element_id");
            entity.Property(e => e.IsPublic)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("is_public");
            entity.Property(e => e.IsResolved).HasColumnName("is_resolved");
            entity.Property(e => e.LastActivityAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("datetime")
                .HasColumnName("last_activity_at");
            entity.Property(e => e.ParentId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("parent_id");
            entity.Property(e => e.Position)
                .HasDefaultValueSql("'NULL'")
                .HasComment("A JSON string that represents the position of the note inside the element in percentages. e.g. {x:10, y:15}")
                .HasColumnType("text")
                .HasColumnName("position");
            entity.Property(e => e.PostId)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("post_id");
            entity.Property(e => e.RoutePostId)
                .HasDefaultValueSql("'NULL'")
                .HasComment("The post id of the route that the note was created on.")
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("route_post_id");
            entity.Property(e => e.RouteTitle)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("route_title");
            entity.Property(e => e.RouteUrl)
                .HasDefaultValueSql("'NULL'")
                .HasComment("Clean url where the note was created.")
                .HasColumnType("text")
                .HasColumnName("route_url");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasDefaultValueSql("'''publish'''")
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Yv5w6h8fENotesUsersRelation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_e_notes_users_relations");

            entity.HasIndex(e => e.NoteId, "note_id_index");

            entity.HasIndex(e => e.Type, "type_index");

            entity.HasIndex(e => e.UserId, "user_id_index");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.NoteId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("note_id");
            entity.Property(e => e.Type)
                .HasMaxLength(60)
                .HasComment("The relation type between user and note (e.g mention, watch, read).")
                .HasColumnName("type");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<Yv5w6h8fESubmission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_e_submissions");

            entity.HasIndex(e => e.CampaignId, "campaign_id_index");

            entity.HasIndex(e => e.CreatedAtGmt, "created_at_gmt_index");

            entity.HasIndex(e => e.CreatedAt, "created_at_index");

            entity.HasIndex(e => e.ElementId, "element_id_index");

            entity.HasIndex(e => e.HashId, "hash_id_index");

            entity.HasIndex(e => e.HashId, "hash_id_unique_index").IsUnique();

            entity.HasIndex(e => e.IsRead, "is_read_index");

            entity.HasIndex(e => e.MainMetaId, "main_meta_id_index");

            entity.HasIndex(e => e.PostId, "post_id_index");

            entity.HasIndex(e => e.Referer, "referer_index");

            entity.HasIndex(e => e.RefererTitle, "referer_title_index");

            entity.HasIndex(e => e.Status, "status_index");

            entity.HasIndex(e => e.Type, "type_index");

            entity.HasIndex(e => e.UpdatedAtGmt, "updated_at_gmt_index");

            entity.HasIndex(e => e.UpdatedAt, "updated_at_index");

            entity.HasIndex(e => e.UserId, "user_id_index");

            entity.HasIndex(e => e.UserIp, "user_ip_index");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.ActionsCount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("actions_count");
            entity.Property(e => e.ActionsSucceededCount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("actions_succeeded_count");
            entity.Property(e => e.CampaignId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("campaign_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedAtGmt)
                .HasColumnType("datetime")
                .HasColumnName("created_at_gmt");
            entity.Property(e => e.ElementId)
                .HasMaxLength(20)
                .HasColumnName("element_id");
            entity.Property(e => e.FormName)
                .HasMaxLength(60)
                .HasColumnName("form_name");
            entity.Property(e => e.HashId)
                .HasMaxLength(60)
                .HasColumnName("hash_id");
            entity.Property(e => e.IsRead).HasColumnName("is_read");
            entity.Property(e => e.MainMetaId)
                .HasComment("Id of main field. to represent the main meta field")
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("main_meta_id");
            entity.Property(e => e.Meta)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("text")
                .HasColumnName("meta");
            entity.Property(e => e.PostId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("post_id");
            entity.Property(e => e.Referer)
                .HasMaxLength(500)
                .HasColumnName("referer");
            entity.Property(e => e.RefererTitle)
                .HasMaxLength(300)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("referer_title");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasColumnName("status");
            entity.Property(e => e.Type)
                .HasMaxLength(60)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("type");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedAtGmt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at_gmt");
            entity.Property(e => e.UserAgent)
                .HasColumnType("text")
                .HasColumnName("user_agent");
            entity.Property(e => e.UserId)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("user_id");
            entity.Property(e => e.UserIp)
                .HasMaxLength(46)
                .HasColumnName("user_ip");
        });

        modelBuilder.Entity<Yv5w6h8fESubmissionsActionsLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_e_submissions_actions_log");

            entity.HasIndex(e => e.ActionName, "action_name_index");

            entity.HasIndex(e => e.CreatedAtGmt, "created_at_gmt_index");

            entity.HasIndex(e => e.CreatedAt, "created_at_index");

            entity.HasIndex(e => e.Status, "status_index");

            entity.HasIndex(e => e.SubmissionId, "submission_id_index");

            entity.HasIndex(e => e.UpdatedAtGmt, "updated_at_gmt_index");

            entity.HasIndex(e => e.UpdatedAt, "updated_at_index");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.ActionLabel)
                .HasMaxLength(60)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("action_label");
            entity.Property(e => e.ActionName)
                .HasMaxLength(60)
                .HasColumnName("action_name");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedAtGmt)
                .HasColumnType("datetime")
                .HasColumnName("created_at_gmt");
            entity.Property(e => e.Log)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("text")
                .HasColumnName("log");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasColumnName("status");
            entity.Property(e => e.SubmissionId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("submission_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedAtGmt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at_gmt");
        });

        modelBuilder.Entity<Yv5w6h8fESubmissionsValue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_e_submissions_values");

            entity.HasIndex(e => e.Key, "key_index");

            entity.HasIndex(e => e.SubmissionId, "submission_id_index");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.Key)
                .HasMaxLength(60)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("key");
            entity.Property(e => e.SubmissionId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("submission_id");
            entity.Property(e => e.Value)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("value");
        });

        modelBuilder.Entity<Yv5w6h8fLink>(entity =>
        {
            entity.HasKey(e => e.LinkId).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_links");

            entity.HasIndex(e => e.LinkVisible, "link_visible");

            entity.Property(e => e.LinkId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("link_id");
            entity.Property(e => e.LinkDescription)
                .HasMaxLength(255)
                .HasDefaultValueSql("''''''")
                .HasColumnName("link_description");
            entity.Property(e => e.LinkImage)
                .HasMaxLength(255)
                .HasDefaultValueSql("''''''")
                .HasColumnName("link_image");
            entity.Property(e => e.LinkName)
                .HasMaxLength(255)
                .HasDefaultValueSql("''''''")
                .HasColumnName("link_name");
            entity.Property(e => e.LinkNotes)
                .HasColumnType("mediumtext")
                .HasColumnName("link_notes");
            entity.Property(e => e.LinkOwner)
                .HasDefaultValueSql("'1'")
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("link_owner");
            entity.Property(e => e.LinkRating)
                .HasColumnType("int(11)")
                .HasColumnName("link_rating");
            entity.Property(e => e.LinkRel)
                .HasMaxLength(255)
                .HasDefaultValueSql("''''''")
                .HasColumnName("link_rel");
            entity.Property(e => e.LinkRss)
                .HasMaxLength(255)
                .HasDefaultValueSql("''''''")
                .HasColumnName("link_rss");
            entity.Property(e => e.LinkTarget)
                .HasMaxLength(25)
                .HasDefaultValueSql("''''''")
                .HasColumnName("link_target");
            entity.Property(e => e.LinkUpdated)
                .HasDefaultValueSql("'''0000-00-00 00:00:00'''")
                .HasColumnType("datetime")
                .HasColumnName("link_updated");
            entity.Property(e => e.LinkUrl)
                .HasMaxLength(255)
                .HasDefaultValueSql("''''''")
                .HasColumnName("link_url");
            entity.Property(e => e.LinkVisible)
                .HasMaxLength(20)
                .HasDefaultValueSql("'''Y'''")
                .HasColumnName("link_visible");
        });

        modelBuilder.Entity<Yv5w6h8fLitespeedUrl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_litespeed_url");

            entity.HasIndex(e => e.CacheTags, "cache_tags");

            entity.HasIndex(e => e.Url, "url").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20)")
                .HasColumnName("id");
            entity.Property(e => e.CacheTags)
                .HasMaxLength(1000)
                .HasDefaultValueSql("''''''")
                .HasColumnName("cache_tags");
            entity.Property(e => e.Url)
                .HasMaxLength(500)
                .HasColumnName("url");
        });

        modelBuilder.Entity<Yv5w6h8fLitespeedUrlFile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_litespeed_url_file");

            entity.HasIndex(e => e.Filename, "filename");

            entity.HasIndex(e => new { e.Filename, e.Expired }, "filename_2");

            entity.HasIndex(e => e.Type, "type");

            entity.HasIndex(e => new { e.UrlId, e.Expired }, "url_id");

            entity.HasIndex(e => new { e.UrlId, e.Vary, e.Type }, "url_id_2");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20)")
                .HasColumnName("id");
            entity.Property(e => e.Expired)
                .HasColumnType("int(11)")
                .HasColumnName("expired");
            entity.Property(e => e.Filename)
                .HasMaxLength(32)
                .HasDefaultValueSql("''''''")
                .HasComment("md5 of file content")
                .HasColumnName("filename");
            entity.Property(e => e.Mobile)
                .HasComment("mobile=1")
                .HasColumnType("tinyint(4)")
                .HasColumnName("mobile");
            entity.Property(e => e.Type)
                .HasComment("css=1,js=2,ccss=3,ucss=4")
                .HasColumnType("tinyint(4)")
                .HasColumnName("type");
            entity.Property(e => e.UrlId)
                .HasColumnType("bigint(20)")
                .HasColumnName("url_id");
            entity.Property(e => e.Vary)
                .HasMaxLength(32)
                .HasDefaultValueSql("''''''")
                .HasComment("md5 of final vary")
                .HasColumnName("vary");
            entity.Property(e => e.Webp)
                .HasComment("webp=1")
                .HasColumnType("tinyint(4)")
                .HasColumnName("webp");
        });

        modelBuilder.Entity<Yv5w6h8fOption>(entity =>
        {
            entity.HasKey(e => e.OptionId).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_options");

            entity.HasIndex(e => e.Autoload, "autoload");

            entity.HasIndex(e => e.OptionName, "option_name").IsUnique();

            entity.Property(e => e.OptionId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("option_id");
            entity.Property(e => e.Autoload)
                .HasMaxLength(20)
                .HasDefaultValueSql("'''yes'''")
                .HasColumnName("autoload");
            entity.Property(e => e.OptionName)
                .HasMaxLength(191)
                .HasDefaultValueSql("''''''")
                .HasColumnName("option_name");
            entity.Property(e => e.OptionValue).HasColumnName("option_value");
        });

        modelBuilder.Entity<Yv5w6h8fPost>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_posts");

            entity.HasIndex(e => e.PostAuthor, "post_author");

            entity.HasIndex(e => e.PostName, "post_name");

            entity.HasIndex(e => e.PostParent, "post_parent");

            entity.HasIndex(e => new { e.PostType, e.PostStatus, e.PostDate, e.Id }, "type_status_date");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("ID");
            entity.Property(e => e.CommentCount)
                .HasColumnType("bigint(20)")
                .HasColumnName("comment_count");
            entity.Property(e => e.CommentStatus)
                .HasMaxLength(20)
                .HasDefaultValueSql("'''open'''")
                .HasColumnName("comment_status");
            entity.Property(e => e.Guid)
                .HasMaxLength(255)
                .HasDefaultValueSql("''''''")
                .HasColumnName("guid");
            entity.Property(e => e.MenuOrder)
                .HasColumnType("int(11)")
                .HasColumnName("menu_order");
            entity.Property(e => e.PingStatus)
                .HasMaxLength(20)
                .HasDefaultValueSql("'''open'''")
                .HasColumnName("ping_status");
            entity.Property(e => e.Pinged)
                .HasColumnType("text")
                .HasColumnName("pinged");
            entity.Property(e => e.PostAuthor)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("post_author");
            entity.Property(e => e.PostContent).HasColumnName("post_content");
            entity.Property(e => e.PostContentFiltered).HasColumnName("post_content_filtered");
            entity.Property(e => e.PostDate)
                .HasDefaultValueSql("'''0000-00-00 00:00:00'''")
                .HasColumnType("datetime")
                .HasColumnName("post_date");
            entity.Property(e => e.PostDateGmt)
                .HasDefaultValueSql("'''0000-00-00 00:00:00'''")
                .HasColumnType("datetime")
                .HasColumnName("post_date_gmt");
            entity.Property(e => e.PostExcerpt)
                .HasColumnType("text")
                .HasColumnName("post_excerpt");
            entity.Property(e => e.PostMimeType)
                .HasMaxLength(100)
                .HasDefaultValueSql("''''''")
                .HasColumnName("post_mime_type");
            entity.Property(e => e.PostModified)
                .HasDefaultValueSql("'''0000-00-00 00:00:00'''")
                .HasColumnType("datetime")
                .HasColumnName("post_modified");
            entity.Property(e => e.PostModifiedGmt)
                .HasDefaultValueSql("'''0000-00-00 00:00:00'''")
                .HasColumnType("datetime")
                .HasColumnName("post_modified_gmt");
            entity.Property(e => e.PostName)
                .HasMaxLength(200)
                .HasDefaultValueSql("''''''")
                .HasColumnName("post_name");
            entity.Property(e => e.PostParent)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("post_parent");
            entity.Property(e => e.PostPassword)
                .HasMaxLength(255)
                .HasDefaultValueSql("''''''")
                .HasColumnName("post_password");
            entity.Property(e => e.PostStatus)
                .HasMaxLength(20)
                .HasDefaultValueSql("'''publish'''")
                .HasColumnName("post_status");
            entity.Property(e => e.PostTitle)
                .HasColumnType("text")
                .HasColumnName("post_title");
            entity.Property(e => e.PostType)
                .HasMaxLength(20)
                .HasDefaultValueSql("'''post'''")
                .HasColumnName("post_type");
            entity.Property(e => e.ToPing)
                .HasColumnType("text")
                .HasColumnName("to_ping");
        });

        modelBuilder.Entity<Yv5w6h8fPostmetum>(entity =>
        {
            entity.HasKey(e => e.MetaId).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_postmeta");

            entity.HasIndex(e => e.MetaKey, "meta_key");

            entity.HasIndex(e => e.PostId, "post_id");

            entity.Property(e => e.MetaId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("meta_id");
            entity.Property(e => e.MetaKey)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("meta_key");
            entity.Property(e => e.MetaValue)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("meta_value");
            entity.Property(e => e.PostId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("post_id");
        });

        modelBuilder.Entity<Yv5w6h8fSnippet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_snippets");

            entity.HasIndex(e => e.Active, "active");

            entity.HasIndex(e => e.Scope, "scope");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20)")
                .HasColumnName("id");
            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.CloudId)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("cloud_id");
            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.Modified)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Name)
                .HasColumnType("tinytext")
                .HasColumnName("name");
            entity.Property(e => e.Priority)
                .HasDefaultValueSql("'10'")
                .HasColumnType("smallint(6)")
                .HasColumnName("priority");
            entity.Property(e => e.Revision)
                .HasDefaultValueSql("'1'")
                .HasColumnType("bigint(20)")
                .HasColumnName("revision");
            entity.Property(e => e.Scope)
                .HasMaxLength(15)
                .HasDefaultValueSql("'''global'''")
                .HasColumnName("scope");
            entity.Property(e => e.Tags).HasColumnName("tags");
        });

        modelBuilder.Entity<Yv5w6h8fTerm>(entity =>
        {
            entity.HasKey(e => e.TermId).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_terms");

            entity.HasIndex(e => e.Name, "name");

            entity.HasIndex(e => e.Slug, "slug");

            entity.Property(e => e.TermId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("term_id");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .HasDefaultValueSql("''''''")
                .HasColumnName("name");
            entity.Property(e => e.Slug)
                .HasMaxLength(200)
                .HasDefaultValueSql("''''''")
                .HasColumnName("slug");
            entity.Property(e => e.TermGroup)
                .HasColumnType("bigint(10)")
                .HasColumnName("term_group");
        });

        modelBuilder.Entity<Yv5w6h8fTermRelationship>(entity =>
        {
            entity.HasKey(e => new { e.ObjectId, e.TermTaxonomyId }).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_term_relationships");

            entity.HasIndex(e => e.TermTaxonomyId, "term_taxonomy_id");

            entity.Property(e => e.ObjectId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("object_id");
            entity.Property(e => e.TermTaxonomyId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("term_taxonomy_id");
            entity.Property(e => e.TermOrder)
                .HasColumnType("int(11)")
                .HasColumnName("term_order");
        });

        modelBuilder.Entity<Yv5w6h8fTermTaxonomy>(entity =>
        {
            entity.HasKey(e => e.TermTaxonomyId).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_term_taxonomy");

            entity.HasIndex(e => e.Taxonomy, "taxonomy");

            entity.HasIndex(e => new { e.TermId, e.Taxonomy }, "term_id_taxonomy").IsUnique();

            entity.Property(e => e.TermTaxonomyId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("term_taxonomy_id");
            entity.Property(e => e.Count)
                .HasColumnType("bigint(20)")
                .HasColumnName("count");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Parent)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("parent");
            entity.Property(e => e.Taxonomy)
                .HasMaxLength(32)
                .HasDefaultValueSql("''''''")
                .HasColumnName("taxonomy");
            entity.Property(e => e.TermId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("term_id");
        });

        modelBuilder.Entity<Yv5w6h8fTermmetum>(entity =>
        {
            entity.HasKey(e => e.MetaId).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_termmeta");

            entity.HasIndex(e => e.MetaKey, "meta_key");

            entity.HasIndex(e => e.TermId, "term_id");

            entity.Property(e => e.MetaId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("meta_id");
            entity.Property(e => e.MetaKey)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("meta_key");
            entity.Property(e => e.MetaValue)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("meta_value");
            entity.Property(e => e.TermId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("term_id");
        });

        modelBuilder.Entity<Yv5w6h8fUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_users");

            entity.HasIndex(e => e.UserEmail, "user_email");

            entity.HasIndex(e => e.UserLogin, "user_login_key");

            entity.HasIndex(e => e.UserNicename, "user_nicename");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("ID");
            entity.Property(e => e.DisplayName)
                .HasMaxLength(250)
                .HasDefaultValueSql("''''''")
                .HasColumnName("display_name");
            entity.Property(e => e.UserActivationKey)
                .HasMaxLength(255)
                .HasDefaultValueSql("''''''")
                .HasColumnName("user_activation_key");
            entity.Property(e => e.UserEmail)
                .HasMaxLength(100)
                .HasDefaultValueSql("''''''")
                .HasColumnName("user_email");
            entity.Property(e => e.UserLogin)
                .HasMaxLength(60)
                .HasDefaultValueSql("''''''")
                .HasColumnName("user_login");
            entity.Property(e => e.UserNicename)
                .HasMaxLength(50)
                .HasDefaultValueSql("''''''")
                .HasColumnName("user_nicename");
            entity.Property(e => e.UserPass)
                .HasMaxLength(255)
                .HasDefaultValueSql("''''''")
                .HasColumnName("user_pass");
            entity.Property(e => e.UserRegistered)
                .HasDefaultValueSql("'''0000-00-00 00:00:00'''")
                .HasColumnType("datetime")
                .HasColumnName("user_registered");
            entity.Property(e => e.UserStatus)
                .HasColumnType("int(11)")
                .HasColumnName("user_status");
            entity.Property(e => e.UserUrl)
                .HasMaxLength(100)
                .HasDefaultValueSql("''''''")
                .HasColumnName("user_url");
        });

        modelBuilder.Entity<Yv5w6h8fUsermetum>(entity =>
        {
            entity.HasKey(e => e.UmetaId).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_usermeta");

            entity.HasIndex(e => e.MetaKey, "meta_key");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.UmetaId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("umeta_id");
            entity.Property(e => e.MetaKey)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("meta_key");
            entity.Property(e => e.MetaValue)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("meta_value");
            entity.Property(e => e.UserId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<Yv5w6h8fWcAdminNote>(entity =>
        {
            entity.HasKey(e => e.NoteId).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_wc_admin_notes");

            entity.Property(e => e.NoteId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("note_id");
            entity.Property(e => e.Content).HasColumnName("content");
            entity.Property(e => e.ContentData)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("content_data");
            entity.Property(e => e.DateCreated)
                .HasDefaultValueSql("'''0000-00-00 00:00:00'''")
                .HasColumnType("datetime")
                .HasColumnName("date_created");
            entity.Property(e => e.DateReminder)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("datetime")
                .HasColumnName("date_reminder");
            entity.Property(e => e.Icon)
                .HasMaxLength(200)
                .HasDefaultValueSql("'''info'''")
                .HasColumnName("icon");
            entity.Property(e => e.Image)
                .HasMaxLength(200)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("image");
            entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
            entity.Property(e => e.IsRead).HasColumnName("is_read");
            entity.Property(e => e.IsSnoozable).HasColumnName("is_snoozable");
            entity.Property(e => e.Layout)
                .HasMaxLength(20)
                .HasDefaultValueSql("''''''")
                .HasColumnName("layout");
            entity.Property(e => e.Locale)
                .HasMaxLength(20)
                .HasColumnName("locale");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Source)
                .HasMaxLength(200)
                .HasColumnName("source");
            entity.Property(e => e.Status)
                .HasMaxLength(200)
                .HasColumnName("status");
            entity.Property(e => e.Title).HasColumnName("title");
            entity.Property(e => e.Type)
                .HasMaxLength(20)
                .HasColumnName("type");
        });

        modelBuilder.Entity<Yv5w6h8fWcAdminNoteAction>(entity =>
        {
            entity.HasKey(e => e.ActionId).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_wc_admin_note_actions");

            entity.HasIndex(e => e.NoteId, "note_id");

            entity.Property(e => e.ActionId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("action_id");
            entity.Property(e => e.ActionedText)
                .HasMaxLength(255)
                .HasColumnName("actioned_text");
            entity.Property(e => e.Label)
                .HasMaxLength(255)
                .HasColumnName("label");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.NonceAction)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("nonce_action");
            entity.Property(e => e.NonceName)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("nonce_name");
            entity.Property(e => e.NoteId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("note_id");
            entity.Property(e => e.Query).HasColumnName("query");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasColumnName("status");
        });

        modelBuilder.Entity<Yv5w6h8fWcCategoryLookup>(entity =>
        {
            entity.HasKey(e => new { e.CategoryTreeId, e.CategoryId }).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_wc_category_lookup");

            entity.Property(e => e.CategoryTreeId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("category_tree_id");
            entity.Property(e => e.CategoryId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("category_id");
        });

        modelBuilder.Entity<Yv5w6h8fWcCustomerLookup>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_wc_customer_lookup");

            entity.HasIndex(e => e.Email, "email");

            entity.HasIndex(e => e.UserId, "user_id").IsUnique();

            entity.Property(e => e.CustomerId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("customer_id");
            entity.Property(e => e.City)
                .HasMaxLength(100)
                .HasDefaultValueSql("''''''")
                .HasColumnName("city");
            entity.Property(e => e.Country)
                .HasMaxLength(2)
                .HasDefaultValueSql("''''''")
                .IsFixedLength()
                .HasColumnName("country");
            entity.Property(e => e.DateLastActive)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("date_last_active");
            entity.Property(e => e.DateRegistered)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("date_registered");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .HasColumnName("last_name");
            entity.Property(e => e.Postcode)
                .HasMaxLength(20)
                .HasDefaultValueSql("''''''")
                .HasColumnName("postcode");
            entity.Property(e => e.State)
                .HasMaxLength(100)
                .HasDefaultValueSql("''''''")
                .HasColumnName("state");
            entity.Property(e => e.UserId)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("user_id");
            entity.Property(e => e.Username)
                .HasMaxLength(60)
                .HasDefaultValueSql("''''''")
                .HasColumnName("username");
        });

        modelBuilder.Entity<Yv5w6h8fWcDownloadLog>(entity =>
        {
            entity.HasKey(e => e.DownloadLogId).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_wc_download_log");

            entity.HasIndex(e => e.PermissionId, "permission_id");

            entity.HasIndex(e => e.Timestamp, "timestamp");

            entity.Property(e => e.DownloadLogId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("download_log_id");
            entity.Property(e => e.PermissionId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("permission_id");
            entity.Property(e => e.Timestamp)
                .HasColumnType("datetime")
                .HasColumnName("timestamp");
            entity.Property(e => e.UserId)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("user_id");
            entity.Property(e => e.UserIpAddress)
                .HasMaxLength(100)
                .HasDefaultValueSql("''''''")
                .HasColumnName("user_ip_address");
        });

        modelBuilder.Entity<Yv5w6h8fWcOrder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_wc_orders");

            entity.HasIndex(e => e.BillingEmail, "billing_email");

            entity.HasIndex(e => new { e.CustomerId, e.BillingEmail }, "customer_id_billing_email");

            entity.HasIndex(e => e.DateCreatedGmt, "date_created");

            entity.HasIndex(e => e.DateUpdatedGmt, "date_updated");

            entity.HasIndex(e => e.ParentOrderId, "parent_order_id");

            entity.HasIndex(e => e.Status, "status");

            entity.HasIndex(e => new { e.Type, e.Status, e.DateCreatedGmt }, "type_status_date");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.BillingEmail)
                .HasMaxLength(320)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("billing_email");
            entity.Property(e => e.Currency)
                .HasMaxLength(10)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("currency");
            entity.Property(e => e.CustomerId)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("customer_id");
            entity.Property(e => e.CustomerNote)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("text")
                .HasColumnName("customer_note");
            entity.Property(e => e.DateCreatedGmt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("datetime")
                .HasColumnName("date_created_gmt");
            entity.Property(e => e.DateUpdatedGmt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("datetime")
                .HasColumnName("date_updated_gmt");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(100)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("ip_address");
            entity.Property(e => e.ParentOrderId)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("parent_order_id");
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(100)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("payment_method");
            entity.Property(e => e.PaymentMethodTitle)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("text")
                .HasColumnName("payment_method_title");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("status");
            entity.Property(e => e.TaxAmount)
                .HasPrecision(26, 8)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("tax_amount");
            entity.Property(e => e.TotalAmount)
                .HasPrecision(26, 8)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("total_amount");
            entity.Property(e => e.TransactionId)
                .HasMaxLength(100)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("transaction_id");
            entity.Property(e => e.Type)
                .HasMaxLength(20)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("type");
            entity.Property(e => e.UserAgent)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("text")
                .HasColumnName("user_agent");
        });

        modelBuilder.Entity<Yv5w6h8fWcOrderAddress>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_wc_order_addresses");

            entity.HasIndex(e => new { e.AddressType, e.OrderId }, "address_type_order_id").IsUnique();

            entity.HasIndex(e => e.Email, "email");

            entity.HasIndex(e => e.OrderId, "order_id");

            entity.HasIndex(e => e.Phone, "phone");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.Address1)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("text")
                .HasColumnName("address_1");
            entity.Property(e => e.Address2)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("text")
                .HasColumnName("address_2");
            entity.Property(e => e.AddressType)
                .HasMaxLength(20)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("address_type");
            entity.Property(e => e.City)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("text")
                .HasColumnName("city");
            entity.Property(e => e.Company)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("text")
                .HasColumnName("company");
            entity.Property(e => e.Country)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("text")
                .HasColumnName("country");
            entity.Property(e => e.Email)
                .HasMaxLength(320)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("text")
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("text")
                .HasColumnName("last_name");
            entity.Property(e => e.OrderId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("order_id");
            entity.Property(e => e.Phone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("phone");
            entity.Property(e => e.Postcode)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("text")
                .HasColumnName("postcode");
            entity.Property(e => e.State)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("text")
                .HasColumnName("state");
        });

        modelBuilder.Entity<Yv5w6h8fWcOrderCouponLookup>(entity =>
        {
            entity.HasKey(e => new { e.OrderId, e.CouponId }).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_wc_order_coupon_lookup");

            entity.HasIndex(e => e.CouponId, "coupon_id");

            entity.HasIndex(e => e.DateCreated, "date_created");

            entity.Property(e => e.OrderId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("order_id");
            entity.Property(e => e.CouponId)
                .HasColumnType("bigint(20)")
                .HasColumnName("coupon_id");
            entity.Property(e => e.DateCreated)
                .HasDefaultValueSql("'''0000-00-00 00:00:00'''")
                .HasColumnType("datetime")
                .HasColumnName("date_created");
            entity.Property(e => e.DiscountAmount).HasColumnName("discount_amount");
        });

        modelBuilder.Entity<Yv5w6h8fWcOrderOperationalDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_wc_order_operational_data");

            entity.HasIndex(e => e.OrderId, "order_id").IsUnique();

            entity.HasIndex(e => e.OrderKey, "order_key");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.CartHash)
                .HasMaxLength(100)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("cart_hash");
            entity.Property(e => e.CouponUsagesAreCounted)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("coupon_usages_are_counted");
            entity.Property(e => e.CreatedVia)
                .HasMaxLength(100)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("created_via");
            entity.Property(e => e.DateCompletedGmt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("datetime")
                .HasColumnName("date_completed_gmt");
            entity.Property(e => e.DatePaidGmt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("datetime")
                .HasColumnName("date_paid_gmt");
            entity.Property(e => e.DiscountTaxAmount)
                .HasPrecision(26, 8)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("discount_tax_amount");
            entity.Property(e => e.DiscountTotalAmount)
                .HasPrecision(26, 8)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("discount_total_amount");
            entity.Property(e => e.DownloadPermissionGranted)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("download_permission_granted");
            entity.Property(e => e.NewOrderEmailSent)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("new_order_email_sent");
            entity.Property(e => e.OrderId)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("order_id");
            entity.Property(e => e.OrderKey)
                .HasMaxLength(100)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("order_key");
            entity.Property(e => e.OrderStockReduced)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("order_stock_reduced");
            entity.Property(e => e.PricesIncludeTax)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("prices_include_tax");
            entity.Property(e => e.RecordedSales)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("recorded_sales");
            entity.Property(e => e.ShippingTaxAmount)
                .HasPrecision(26, 8)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("shipping_tax_amount");
            entity.Property(e => e.ShippingTotalAmount)
                .HasPrecision(26, 8)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("shipping_total_amount");
            entity.Property(e => e.WoocommerceVersion)
                .HasMaxLength(20)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("woocommerce_version");
        });

        modelBuilder.Entity<Yv5w6h8fWcOrderProductLookup>(entity =>
        {
            entity.HasKey(e => e.OrderItemId).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_wc_order_product_lookup");

            entity.HasIndex(e => e.CustomerId, "customer_id");

            entity.HasIndex(e => e.DateCreated, "date_created");

            entity.HasIndex(e => e.OrderId, "order_id");

            entity.HasIndex(e => e.ProductId, "product_id");

            entity.Property(e => e.OrderItemId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("order_item_id");
            entity.Property(e => e.CouponAmount).HasColumnName("coupon_amount");
            entity.Property(e => e.CustomerId)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("customer_id");
            entity.Property(e => e.DateCreated)
                .HasDefaultValueSql("'''0000-00-00 00:00:00'''")
                .HasColumnType("datetime")
                .HasColumnName("date_created");
            entity.Property(e => e.OrderId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("order_id");
            entity.Property(e => e.ProductGrossRevenue).HasColumnName("product_gross_revenue");
            entity.Property(e => e.ProductId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("product_id");
            entity.Property(e => e.ProductNetRevenue).HasColumnName("product_net_revenue");
            entity.Property(e => e.ProductQty)
                .HasColumnType("int(11)")
                .HasColumnName("product_qty");
            entity.Property(e => e.ShippingAmount).HasColumnName("shipping_amount");
            entity.Property(e => e.ShippingTaxAmount).HasColumnName("shipping_tax_amount");
            entity.Property(e => e.TaxAmount).HasColumnName("tax_amount");
            entity.Property(e => e.VariationId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("variation_id");
        });

        modelBuilder.Entity<Yv5w6h8fWcOrderStat>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_wc_order_stats");

            entity.HasIndex(e => e.CustomerId, "customer_id");

            entity.HasIndex(e => e.DateCreated, "date_created");

            entity.HasIndex(e => e.Status, "status");

            entity.Property(e => e.OrderId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("order_id");
            entity.Property(e => e.CustomerId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("customer_id");
            entity.Property(e => e.DateCompleted)
                .HasDefaultValueSql("'''0000-00-00 00:00:00'''")
                .HasColumnType("datetime")
                .HasColumnName("date_completed");
            entity.Property(e => e.DateCreated)
                .HasDefaultValueSql("'''0000-00-00 00:00:00'''")
                .HasColumnType("datetime")
                .HasColumnName("date_created");
            entity.Property(e => e.DateCreatedGmt)
                .HasDefaultValueSql("'''0000-00-00 00:00:00'''")
                .HasColumnType("datetime")
                .HasColumnName("date_created_gmt");
            entity.Property(e => e.DatePaid)
                .HasDefaultValueSql("'''0000-00-00 00:00:00'''")
                .HasColumnType("datetime")
                .HasColumnName("date_paid");
            entity.Property(e => e.NetTotal).HasColumnName("net_total");
            entity.Property(e => e.NumItemsSold)
                .HasColumnType("int(11)")
                .HasColumnName("num_items_sold");
            entity.Property(e => e.ParentId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("parent_id");
            entity.Property(e => e.ReturningCustomer)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("returning_customer");
            entity.Property(e => e.ShippingTotal).HasColumnName("shipping_total");
            entity.Property(e => e.Status)
                .HasMaxLength(200)
                .HasColumnName("status");
            entity.Property(e => e.TaxTotal).HasColumnName("tax_total");
            entity.Property(e => e.TotalSales).HasColumnName("total_sales");
        });

        modelBuilder.Entity<Yv5w6h8fWcOrderTaxLookup>(entity =>
        {
            entity.HasKey(e => new { e.OrderId, e.TaxRateId }).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_wc_order_tax_lookup");

            entity.HasIndex(e => e.DateCreated, "date_created");

            entity.HasIndex(e => e.TaxRateId, "tax_rate_id");

            entity.Property(e => e.OrderId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("order_id");
            entity.Property(e => e.TaxRateId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("tax_rate_id");
            entity.Property(e => e.DateCreated)
                .HasDefaultValueSql("'''0000-00-00 00:00:00'''")
                .HasColumnType("datetime")
                .HasColumnName("date_created");
            entity.Property(e => e.OrderTax).HasColumnName("order_tax");
            entity.Property(e => e.ShippingTax).HasColumnName("shipping_tax");
            entity.Property(e => e.TotalTax).HasColumnName("total_tax");
        });

        modelBuilder.Entity<Yv5w6h8fWcOrdersMetum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_wc_orders_meta");

            entity.HasIndex(e => new { e.MetaKey, e.MetaValue }, "meta_key_value");

            entity.HasIndex(e => new { e.OrderId, e.MetaKey, e.MetaValue }, "order_id_meta_key_meta_value");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.MetaKey)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("meta_key");
            entity.Property(e => e.MetaValue)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("text")
                .HasColumnName("meta_value");
            entity.Property(e => e.OrderId)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("order_id");
        });

        modelBuilder.Entity<Yv5w6h8fWcProductAttributesLookup>(entity =>
        {
            entity.HasKey(e => new { e.ProductOrParentId, e.TermId, e.ProductId, e.Taxonomy }).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_wc_product_attributes_lookup");

            entity.HasIndex(e => new { e.IsVariationAttribute, e.TermId }, "is_variation_attribute_term_id");

            entity.Property(e => e.ProductOrParentId)
                .HasColumnType("bigint(20)")
                .HasColumnName("product_or_parent_id");
            entity.Property(e => e.TermId)
                .HasColumnType("bigint(20)")
                .HasColumnName("term_id");
            entity.Property(e => e.ProductId)
                .HasColumnType("bigint(20)")
                .HasColumnName("product_id");
            entity.Property(e => e.Taxonomy)
                .HasMaxLength(32)
                .HasColumnName("taxonomy");
            entity.Property(e => e.InStock).HasColumnName("in_stock");
            entity.Property(e => e.IsVariationAttribute).HasColumnName("is_variation_attribute");
        });

        modelBuilder.Entity<Yv5w6h8fWcProductDownloadDirectory>(entity =>
        {
            entity.HasKey(e => e.UrlId).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_wc_product_download_directories");

            entity.HasIndex(e => e.Url, "url");

            entity.Property(e => e.UrlId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("url_id");
            entity.Property(e => e.Enabled).HasColumnName("enabled");
            entity.Property(e => e.Url)
                .HasMaxLength(256)
                .HasColumnName("url");
        });

        modelBuilder.Entity<Yv5w6h8fWcProductMetaLookup>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_wc_product_meta_lookup");

            entity.HasIndex(e => e.Downloadable, "downloadable");

            entity.HasIndex(e => new { e.MinPrice, e.MaxPrice }, "min_max_price");

            entity.HasIndex(e => e.Onsale, "onsale");

            entity.HasIndex(e => e.StockQuantity, "stock_quantity");

            entity.HasIndex(e => e.StockStatus, "stock_status");

            entity.HasIndex(e => e.Virtual, "virtual");

            entity.Property(e => e.ProductId)
                .HasColumnType("bigint(20)")
                .HasColumnName("product_id");
            entity.Property(e => e.AverageRating)
                .HasPrecision(3)
                .HasDefaultValueSql("'0.00'")
                .HasColumnName("average_rating");
            entity.Property(e => e.Downloadable)
                .HasDefaultValueSql("'0'")
                .HasColumnName("downloadable");
            entity.Property(e => e.MaxPrice)
                .HasPrecision(19, 4)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("max_price");
            entity.Property(e => e.MinPrice)
                .HasPrecision(19, 4)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("min_price");
            entity.Property(e => e.Onsale)
                .HasDefaultValueSql("'0'")
                .HasColumnName("onsale");
            entity.Property(e => e.RatingCount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("rating_count");
            entity.Property(e => e.Sku)
                .HasMaxLength(100)
                .HasDefaultValueSql("''''''")
                .HasColumnName("sku");
            entity.Property(e => e.StockQuantity)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("stock_quantity");
            entity.Property(e => e.StockStatus)
                .HasMaxLength(100)
                .HasDefaultValueSql("'''instock'''")
                .HasColumnName("stock_status");
            entity.Property(e => e.TaxClass)
                .HasMaxLength(100)
                .HasDefaultValueSql("''''''")
                .HasColumnName("tax_class");
            entity.Property(e => e.TaxStatus)
                .HasMaxLength(100)
                .HasDefaultValueSql("'''taxable'''")
                .HasColumnName("tax_status");
            entity.Property(e => e.TotalSales)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("total_sales");
            entity.Property(e => e.Virtual)
                .HasDefaultValueSql("'0'")
                .HasColumnName("virtual");
        });

        modelBuilder.Entity<Yv5w6h8fWcRateLimit>(entity =>
        {
            entity.HasKey(e => e.RateLimitId).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_wc_rate_limits");

            entity.HasIndex(e => e.RateLimitKey, "rate_limit_key").IsUnique();

            entity.Property(e => e.RateLimitId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("rate_limit_id");
            entity.Property(e => e.RateLimitExpiry)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("rate_limit_expiry");
            entity.Property(e => e.RateLimitKey)
                .HasMaxLength(200)
                .HasColumnName("rate_limit_key");
            entity.Property(e => e.RateLimitRemaining)
                .HasColumnType("smallint(10)")
                .HasColumnName("rate_limit_remaining");
        });

        modelBuilder.Entity<Yv5w6h8fWcReservedStock>(entity =>
        {
            entity.HasKey(e => new { e.OrderId, e.ProductId }).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_wc_reserved_stock");

            entity.Property(e => e.OrderId)
                .HasColumnType("bigint(20)")
                .HasColumnName("order_id");
            entity.Property(e => e.ProductId)
                .HasColumnType("bigint(20)")
                .HasColumnName("product_id");
            entity.Property(e => e.Expires)
                .HasDefaultValueSql("'''0000-00-00 00:00:00'''")
                .HasColumnType("datetime")
                .HasColumnName("expires");
            entity.Property(e => e.StockQuantity).HasColumnName("stock_quantity");
            entity.Property(e => e.Timestamp)
                .HasDefaultValueSql("'''0000-00-00 00:00:00'''")
                .HasColumnType("datetime")
                .HasColumnName("timestamp");
        });

        modelBuilder.Entity<Yv5w6h8fWcTaxRateClass>(entity =>
        {
            entity.HasKey(e => e.TaxRateClassId).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_wc_tax_rate_classes");

            entity.HasIndex(e => e.Slug, "slug").IsUnique();

            entity.Property(e => e.TaxRateClassId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("tax_rate_class_id");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .HasDefaultValueSql("''''''")
                .HasColumnName("name");
            entity.Property(e => e.Slug)
                .HasMaxLength(200)
                .HasDefaultValueSql("''''''")
                .HasColumnName("slug");
        });

        modelBuilder.Entity<Yv5w6h8fWcWebhook>(entity =>
        {
            entity.HasKey(e => e.WebhookId).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_wc_webhooks");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.WebhookId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("webhook_id");
            entity.Property(e => e.ApiVersion)
                .HasColumnType("smallint(4)")
                .HasColumnName("api_version");
            entity.Property(e => e.DateCreated)
                .HasDefaultValueSql("'''0000-00-00 00:00:00'''")
                .HasColumnType("datetime")
                .HasColumnName("date_created");
            entity.Property(e => e.DateCreatedGmt)
                .HasDefaultValueSql("'''0000-00-00 00:00:00'''")
                .HasColumnType("datetime")
                .HasColumnName("date_created_gmt");
            entity.Property(e => e.DateModified)
                .HasDefaultValueSql("'''0000-00-00 00:00:00'''")
                .HasColumnType("datetime")
                .HasColumnName("date_modified");
            entity.Property(e => e.DateModifiedGmt)
                .HasDefaultValueSql("'''0000-00-00 00:00:00'''")
                .HasColumnType("datetime")
                .HasColumnName("date_modified_gmt");
            entity.Property(e => e.DeliveryUrl)
                .HasColumnType("text")
                .HasColumnName("delivery_url");
            entity.Property(e => e.FailureCount)
                .HasColumnType("smallint(10)")
                .HasColumnName("failure_count");
            entity.Property(e => e.Name)
                .HasColumnType("text")
                .HasColumnName("name");
            entity.Property(e => e.PendingDelivery).HasColumnName("pending_delivery");
            entity.Property(e => e.Secret)
                .HasColumnType("text")
                .HasColumnName("secret");
            entity.Property(e => e.Status)
                .HasMaxLength(200)
                .HasColumnName("status");
            entity.Property(e => e.Topic)
                .HasMaxLength(200)
                .HasColumnName("topic");
            entity.Property(e => e.UserId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<Yv5w6h8fWcfmDailyAnalysis>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_wcfm_daily_analysis");

            entity.HasIndex(e => new { e.ProductId, e.AuthorId, e.Visited }, "daily_analysis").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20)")
                .HasColumnName("ID");
            entity.Property(e => e.AuthorId)
                .HasColumnType("bigint(20)")
                .HasColumnName("author_id");
            entity.Property(e => e.Count)
                .HasColumnType("bigint(20)")
                .HasColumnName("count");
            entity.Property(e => e.IsProduct).HasColumnName("is_product");
            entity.Property(e => e.IsShop).HasColumnName("is_shop");
            entity.Property(e => e.IsStore).HasColumnName("is_store");
            entity.Property(e => e.ProductId)
                .HasColumnType("bigint(20)")
                .HasColumnName("product_id");
            entity.Property(e => e.Visited)
                .HasDefaultValueSql("'''0000-00-00'''")
                .HasColumnType("date")
                .HasColumnName("visited");
        });

        modelBuilder.Entity<Yv5w6h8fWcfmDetailedAnalysis>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_wcfm_detailed_analysis");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20)")
                .HasColumnName("ID");
            entity.Property(e => e.AuthorId)
                .HasColumnType("bigint(20)")
                .HasColumnName("author_id");
            entity.Property(e => e.City)
                .HasMaxLength(100)
                .HasColumnName("city");
            entity.Property(e => e.Country)
                .HasMaxLength(30)
                .HasColumnName("country");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(60)
                .HasColumnName("ip_address");
            entity.Property(e => e.IsProduct).HasColumnName("is_product");
            entity.Property(e => e.IsShop).HasColumnName("is_shop");
            entity.Property(e => e.IsStore).HasColumnName("is_store");
            entity.Property(e => e.ProductId)
                .HasColumnType("bigint(20)")
                .HasColumnName("product_id");
            entity.Property(e => e.Referer)
                .HasColumnType("text")
                .HasColumnName("referer");
            entity.Property(e => e.State)
                .HasMaxLength(30)
                .HasColumnName("state");
            entity.Property(e => e.Visited)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("visited");
        });

        modelBuilder.Entity<Yv5w6h8fWcfmEnquiriesMetum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_wcfm_enquiries_meta");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20)")
                .HasColumnName("ID");
            entity.Property(e => e.EnquiryId)
                .HasColumnType("bigint(20)")
                .HasColumnName("enquiry_id");
            entity.Property(e => e.Key)
                .HasMaxLength(200)
                .HasColumnName("key");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<Yv5w6h8fWcfmEnquiriesResponse>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_wcfm_enquiries_response");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20)")
                .HasColumnName("ID");
            entity.Property(e => e.CustomerEmail)
                .HasMaxLength(200)
                .HasColumnName("customer_email");
            entity.Property(e => e.CustomerId)
                .HasColumnType("bigint(20)")
                .HasColumnName("customer_id");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(200)
                .HasColumnName("customer_name");
            entity.Property(e => e.EnquiryId)
                .HasColumnType("bigint(20)")
                .HasColumnName("enquiry_id");
            entity.Property(e => e.Posted)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("posted");
            entity.Property(e => e.ProductId)
                .HasColumnType("bigint(20)")
                .HasColumnName("product_id");
            entity.Property(e => e.Reply).HasColumnName("reply");
            entity.Property(e => e.ReplyBy)
                .HasColumnType("bigint(20)")
                .HasColumnName("reply_by");
            entity.Property(e => e.VendorId)
                .HasColumnType("bigint(20)")
                .HasColumnName("vendor_id");
        });

        modelBuilder.Entity<Yv5w6h8fWcfmEnquiriesResponseMetum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_wcfm_enquiries_response_meta");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20)")
                .HasColumnName("ID");
            entity.Property(e => e.EnquiryResponseId)
                .HasColumnType("bigint(20)")
                .HasColumnName("enquiry_response_id");
            entity.Property(e => e.Key)
                .HasMaxLength(200)
                .HasColumnName("key");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<Yv5w6h8fWcfmEnquiry>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_wcfm_enquiries");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20)")
                .HasColumnName("ID");
            entity.Property(e => e.AuthorId)
                .HasColumnType("bigint(20)")
                .HasColumnName("author_id");
            entity.Property(e => e.CustomerEmail)
                .HasMaxLength(200)
                .HasColumnName("customer_email");
            entity.Property(e => e.CustomerId)
                .HasColumnType("bigint(20)")
                .HasColumnName("customer_id");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(200)
                .HasColumnName("customer_name");
            entity.Property(e => e.Enquiry).HasColumnName("enquiry");
            entity.Property(e => e.IsPrivate).HasColumnName("is_private");
            entity.Property(e => e.Posted)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("posted");
            entity.Property(e => e.ProductId)
                .HasColumnType("bigint(20)")
                .HasColumnName("product_id");
            entity.Property(e => e.Replied)
                .HasDefaultValueSql("'''0000-00-00'''")
                .HasColumnType("date")
                .HasColumnName("replied");
            entity.Property(e => e.Reply).HasColumnName("reply");
            entity.Property(e => e.ReplyBy)
                .HasColumnType("bigint(20)")
                .HasColumnName("reply_by");
            entity.Property(e => e.VendorId)
                .HasColumnType("bigint(20)")
                .HasColumnName("vendor_id");
        });

        modelBuilder.Entity<Yv5w6h8fWcfmFbcChatRow>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("yv5w6h8f_wcfm_fbc_chat_rows");

            entity.HasIndex(e => e.MessageId, "message_id").IsUnique();

            entity.Property(e => e.ConversationId)
                .HasMaxLength(30)
                .HasColumnName("conversation_id");
            entity.Property(e => e.MessageId)
                .HasMaxLength(30)
                .HasDefaultValueSql("''''''")
                .HasColumnName("message_id");
            entity.Property(e => e.Msg)
                .HasColumnType("text")
                .HasColumnName("msg");
            entity.Property(e => e.MsgTime)
                .HasColumnType("bigint(13) unsigned")
                .HasColumnName("msg_time");
            entity.Property(e => e.UserId)
                .HasMaxLength(30)
                .HasDefaultValueSql("''''''")
                .HasColumnName("user_id");
            entity.Property(e => e.UserName)
                .HasMaxLength(32)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("user_name");
        });

        modelBuilder.Entity<Yv5w6h8fWcfmFbcChatSession>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("yv5w6h8f_wcfm_fbc_chat_sessions");

            entity.HasIndex(e => e.ConversationId, "conversation_id").IsUnique();

            entity.HasIndex(e => e.CreatedAt, "created_at");

            entity.Property(e => e.ConversationId)
                .HasMaxLength(30)
                .HasDefaultValueSql("''''''")
                .HasColumnName("conversation_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("bigint(13) unsigned")
                .HasColumnName("created_at");
            entity.Property(e => e.Duration)
                .HasMaxLength(30)
                .HasDefaultValueSql("'''00:00:00'''")
                .HasColumnName("duration");
            entity.Property(e => e.Evaluation)
                .HasMaxLength(30)
                .HasDefaultValueSql("''''''")
                .HasColumnName("evaluation");
            entity.Property(e => e.ReceiveCopy).HasColumnName("receive_copy");
            entity.Property(e => e.UserId)
                .HasMaxLength(30)
                .HasDefaultValueSql("''''''")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<Yv5w6h8fWcfmFbcChatVisitor>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("yv5w6h8f_wcfm_fbc_chat_visitors");

            entity.HasIndex(e => e.UserId, "user_id").IsUnique();

            entity.Property(e => e.LastOnline)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("bigint(13) unsigned")
                .HasColumnName("last_online");
            entity.Property(e => e.UserEmail)
                .HasMaxLength(90)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("user_email");
            entity.Property(e => e.UserId)
                .HasMaxLength(30)
                .HasDefaultValueSql("''''''")
                .HasColumnName("user_id");
            entity.Property(e => e.UserIp)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11) unsigned")
                .HasColumnName("user_ip");
            entity.Property(e => e.UserName)
                .HasMaxLength(32)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("user_name");
            entity.Property(e => e.UserType)
                .HasMaxLength(12)
                .HasDefaultValueSql("''''''")
                .HasColumnName("user_type");
            entity.Property(e => e.VendorId)
                .HasMaxLength(30)
                .HasDefaultValueSql("''''''")
                .HasColumnName("vendor_id");
        });

        modelBuilder.Entity<Yv5w6h8fWcfmFbcOfflineMessage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_wcfm_fbc_offline_messages");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.MailDate)
                .HasDefaultValueSql("'''0000-00-00'''")
                .HasColumnType("date")
                .HasColumnName("mail_date");
            entity.Property(e => e.MailRead).HasColumnName("mail_read");
            entity.Property(e => e.UserEmail).HasColumnName("user_email");
            entity.Property(e => e.UserInfo).HasColumnName("user_info");
            entity.Property(e => e.UserMessage).HasColumnName("user_message");
            entity.Property(e => e.UserName).HasColumnName("user_name");
            entity.Property(e => e.VendorId)
                .HasMaxLength(30)
                .HasDefaultValueSql("''''''")
                .HasColumnName("vendor_id");
        });

        modelBuilder.Entity<Yv5w6h8fWcfmFollowingFollower>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_wcfm_following_followers");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20)")
                .HasColumnName("ID");
            entity.Property(e => e.FollowerEmail)
                .HasMaxLength(200)
                .HasColumnName("follower_email");
            entity.Property(e => e.FollowerId)
                .HasColumnType("bigint(20)")
                .HasColumnName("follower_id");
            entity.Property(e => e.FollowerName)
                .HasMaxLength(200)
                .HasColumnName("follower_name");
            entity.Property(e => e.Notify)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("notify");
            entity.Property(e => e.Posted)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("posted");
            entity.Property(e => e.UserEmail)
                .HasMaxLength(200)
                .HasColumnName("user_email");
            entity.Property(e => e.UserId)
                .HasColumnType("bigint(20)")
                .HasColumnName("user_id");
            entity.Property(e => e.UserName)
                .HasMaxLength(200)
                .HasColumnName("user_name");
        });

        modelBuilder.Entity<Yv5w6h8fWcfmMarketplaceOrder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_wcfm_marketplace_orders");

            entity.HasIndex(e => new { e.OrderId, e.VendorId, e.ItemId }, "marketplace_orders").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20)")
                .HasColumnName("ID");
            entity.Property(e => e.CommissionAmount)
                .HasMaxLength(255)
                .HasDefaultValueSql("'''0'''")
                .HasColumnName("commission_amount");
            entity.Property(e => e.CommissionPaidDate)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("commission_paid_date");
            entity.Property(e => e.CommissionStatus)
                .HasMaxLength(100)
                .HasDefaultValueSql("'''pending'''")
                .HasColumnName("commission_status");
            entity.Property(e => e.Created)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("created");
            entity.Property(e => e.CustomerId)
                .HasColumnType("bigint(20)")
                .HasColumnName("customer_id");
            entity.Property(e => e.DiscountAmount)
                .HasMaxLength(255)
                .HasDefaultValueSql("'''0'''")
                .HasColumnName("discount_amount");
            entity.Property(e => e.DiscountType)
                .HasMaxLength(255)
                .HasColumnName("discount_type");
            entity.Property(e => e.IsAutoWithdrawal).HasColumnName("is_auto_withdrawal");
            entity.Property(e => e.IsPartiallyRefunded).HasColumnName("is_partially_refunded");
            entity.Property(e => e.IsRefunded).HasColumnName("is_refunded");
            entity.Property(e => e.IsTrashed).HasColumnName("is_trashed");
            entity.Property(e => e.IsWithdrawable).HasColumnName("is_withdrawable");
            entity.Property(e => e.ItemId)
                .HasColumnType("bigint(20)")
                .HasColumnName("item_id");
            entity.Property(e => e.ItemSubTotal)
                .HasMaxLength(255)
                .HasDefaultValueSql("'''0'''")
                .HasColumnName("item_sub_total");
            entity.Property(e => e.ItemTotal)
                .HasMaxLength(255)
                .HasDefaultValueSql("'''0'''")
                .HasColumnName("item_total");
            entity.Property(e => e.ItemType)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("item_type");
            entity.Property(e => e.OrderId)
                .HasColumnType("bigint(20)")
                .HasColumnName("order_id");
            entity.Property(e => e.OrderStatus)
                .HasMaxLength(255)
                .HasColumnName("order_status");
            entity.Property(e => e.OtherAmount)
                .HasMaxLength(255)
                .HasDefaultValueSql("'''0'''")
                .HasColumnName("other_amount");
            entity.Property(e => e.OtherAmountType)
                .HasMaxLength(255)
                .HasColumnName("other_amount_type");
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(255)
                .HasColumnName("payment_method");
            entity.Property(e => e.ProductId)
                .HasColumnType("bigint(20)")
                .HasColumnName("product_id");
            entity.Property(e => e.ProductPrice)
                .HasMaxLength(255)
                .HasDefaultValueSql("'''0'''")
                .HasColumnName("product_price");
            entity.Property(e => e.PurchasePrice)
                .HasMaxLength(20)
                .HasDefaultValueSql("'''0'''")
                .HasColumnName("purchase_price");
            entity.Property(e => e.Quantity)
                .HasDefaultValueSql("'1'")
                .HasColumnType("bigint(20)")
                .HasColumnName("quantity");
            entity.Property(e => e.RefundStatus)
                .HasMaxLength(100)
                .HasDefaultValueSql("'''pending'''")
                .HasColumnName("refund_status");
            entity.Property(e => e.RefundedAmount)
                .HasMaxLength(255)
                .HasDefaultValueSql("'''0'''")
                .HasColumnName("refunded_amount");
            entity.Property(e => e.RefundedId)
                .HasColumnType("bigint(20)")
                .HasColumnName("refunded_id");
            entity.Property(e => e.Shipping)
                .HasMaxLength(255)
                .HasDefaultValueSql("'''0'''")
                .HasColumnName("shipping");
            entity.Property(e => e.ShippingStatus)
                .HasMaxLength(255)
                .HasDefaultValueSql("'''pending'''")
                .HasColumnName("shipping_status");
            entity.Property(e => e.ShippingTaxAmount)
                .HasMaxLength(255)
                .HasDefaultValueSql("'''0'''")
                .HasColumnName("shipping_tax_amount");
            entity.Property(e => e.Tax)
                .HasMaxLength(255)
                .HasDefaultValueSql("'''0'''")
                .HasColumnName("tax");
            entity.Property(e => e.TotalCommission)
                .HasMaxLength(255)
                .HasDefaultValueSql("'''0'''")
                .HasColumnName("total_commission");
            entity.Property(e => e.VariationId)
                .HasColumnType("bigint(20)")
                .HasColumnName("variation_id");
            entity.Property(e => e.VendorId)
                .HasColumnType("bigint(20)")
                .HasColumnName("vendor_id");
            entity.Property(e => e.WithdrawCharges)
                .HasMaxLength(255)
                .HasDefaultValueSql("'''0'''")
                .HasColumnName("withdraw_charges");
            entity.Property(e => e.WithdrawStatus)
                .HasMaxLength(100)
                .HasDefaultValueSql("'''pending'''")
                .HasColumnName("withdraw_status");
            entity.Property(e => e.WithdrawalId)
                .HasColumnType("bigint(20)")
                .HasColumnName("withdrawal_id");
        });

        modelBuilder.Entity<Yv5w6h8fWcfmMarketplaceOrdersMetum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_wcfm_marketplace_orders_meta");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20)")
                .HasColumnName("ID");
            entity.Property(e => e.Key)
                .HasMaxLength(200)
                .HasColumnName("key");
            entity.Property(e => e.OrderCommissionId)
                .HasColumnType("bigint(20)")
                .HasColumnName("order_commission_id");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<Yv5w6h8fWcfmMarketplaceProductMultivendor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_wcfm_marketplace_product_multivendor");

            entity.HasIndex(e => new { e.ProductId, e.ParentProductId, e.VendorId }, "marketplace_product_multivendor").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20)")
                .HasColumnName("ID");
            entity.Property(e => e.Created)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("created");
            entity.Property(e => e.ParentProductId)
                .HasColumnType("bigint(20)")
                .HasColumnName("parent_product_id");
            entity.Property(e => e.ProductId)
                .HasColumnType("bigint(20)")
                .HasColumnName("product_id");
            entity.Property(e => e.ProductPrice)
                .HasMaxLength(100)
                .HasDefaultValueSql("'''0'''")
                .HasColumnName("product_price");
            entity.Property(e => e.VendorId)
                .HasColumnType("bigint(20)")
                .HasColumnName("vendor_id");
        });

        modelBuilder.Entity<Yv5w6h8fWcfmMarketplaceRefundRequest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_wcfm_marketplace_refund_request");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20)")
                .HasColumnName("ID");
            entity.Property(e => e.ApprovedBy)
                .HasColumnType("bigint(20)")
                .HasColumnName("approved_by");
            entity.Property(e => e.CommissionId)
                .HasColumnType("bigint(20)")
                .HasColumnName("commission_id");
            entity.Property(e => e.Created)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("created");
            entity.Property(e => e.IsPartiallyRefunded).HasColumnName("is_partially_refunded");
            entity.Property(e => e.ItemId)
                .HasColumnType("bigint(20)")
                .HasColumnName("item_id");
            entity.Property(e => e.OrderId)
                .HasColumnType("bigint(20)")
                .HasColumnName("order_id");
            entity.Property(e => e.RefundPaidDate)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("refund_paid_date");
            entity.Property(e => e.RefundReason).HasColumnName("refund_reason");
            entity.Property(e => e.RefundStatus)
                .HasMaxLength(100)
                .HasDefaultValueSql("'''pending'''")
                .HasColumnName("refund_status");
            entity.Property(e => e.RefundedAmount)
                .HasMaxLength(255)
                .HasDefaultValueSql("'''0'''")
                .HasColumnName("refunded_amount");
            entity.Property(e => e.RequestedBy)
                .HasColumnType("bigint(20)")
                .HasColumnName("requested_by");
            entity.Property(e => e.VendorId)
                .HasColumnType("bigint(20)")
                .HasColumnName("vendor_id");
        });

        modelBuilder.Entity<Yv5w6h8fWcfmMarketplaceRefundRequestMetum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_wcfm_marketplace_refund_request_meta");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20)")
                .HasColumnName("ID");
            entity.Property(e => e.Key)
                .HasMaxLength(255)
                .HasColumnName("key");
            entity.Property(e => e.RefundId)
                .HasColumnType("bigint(20)")
                .HasColumnName("refund_id");
            entity.Property(e => e.Value)
                .HasMaxLength(255)
                .HasColumnName("value");
        });

        modelBuilder.Entity<Yv5w6h8fWcfmMarketplaceReverseWithdrawal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_wcfm_marketplace_reverse_withdrawal");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20)")
                .HasColumnName("ID");
            entity.Property(e => e.Balance)
                .HasMaxLength(255)
                .HasDefaultValueSql("'''0'''")
                .HasColumnName("balance");
            entity.Property(e => e.Commission)
                .HasMaxLength(255)
                .HasDefaultValueSql("'''0'''")
                .HasColumnName("commission");
            entity.Property(e => e.CommissionId)
                .HasColumnType("bigint(20)")
                .HasColumnName("commission_id");
            entity.Property(e => e.Created)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("created");
            entity.Property(e => e.GrossTotal)
                .HasMaxLength(255)
                .HasDefaultValueSql("'''0'''")
                .HasColumnName("gross_total");
            entity.Property(e => e.OrderId)
                .HasColumnType("bigint(20)")
                .HasColumnName("order_id");
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(255)
                .HasColumnName("payment_method");
            entity.Property(e => e.VendorId)
                .HasColumnType("bigint(20)")
                .HasColumnName("vendor_id");
            entity.Property(e => e.WithdrawNote).HasColumnName("withdraw_note");
            entity.Property(e => e.WithdrawPaidDate)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("withdraw_paid_date");
            entity.Property(e => e.WithdrawStatus)
                .HasMaxLength(100)
                .HasDefaultValueSql("'''pending'''")
                .HasColumnName("withdraw_status");
        });

        modelBuilder.Entity<Yv5w6h8fWcfmMarketplaceReverseWithdrawalMetum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_wcfm_marketplace_reverse_withdrawal_meta");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20)")
                .HasColumnName("ID");
            entity.Property(e => e.Key)
                .HasMaxLength(255)
                .HasColumnName("key");
            entity.Property(e => e.ReverseWithdrawId)
                .HasColumnType("bigint(20)")
                .HasColumnName("reverse_withdraw_id");
            entity.Property(e => e.Value)
                .HasMaxLength(255)
                .HasColumnName("value");
        });

        modelBuilder.Entity<Yv5w6h8fWcfmMarketplaceReview>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_wcfm_marketplace_reviews");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20)")
                .HasColumnName("ID");
            entity.Property(e => e.Approved).HasColumnName("approved");
            entity.Property(e => e.AuthorEmail)
                .HasMaxLength(255)
                .HasColumnName("author_email");
            entity.Property(e => e.AuthorId)
                .HasColumnType("bigint(20)")
                .HasColumnName("author_id");
            entity.Property(e => e.AuthorName)
                .HasMaxLength(255)
                .HasColumnName("author_name");
            entity.Property(e => e.Created)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("created");
            entity.Property(e => e.ReviewDescription).HasColumnName("review_description");
            entity.Property(e => e.ReviewRating)
                .HasMaxLength(100)
                .HasColumnName("review_rating");
            entity.Property(e => e.ReviewTitle).HasColumnName("review_title");
            entity.Property(e => e.VendorId)
                .HasColumnType("bigint(20)")
                .HasColumnName("vendor_id");
        });

        modelBuilder.Entity<Yv5w6h8fWcfmMarketplaceReviewRatingMetum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_wcfm_marketplace_review_rating_meta");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20)")
                .HasColumnName("ID");
            entity.Property(e => e.Key)
                .HasMaxLength(255)
                .HasColumnName("key");
            entity.Property(e => e.ReviewId)
                .HasColumnType("bigint(20)")
                .HasColumnName("review_id");
            entity.Property(e => e.Type)
                .HasMaxLength(200)
                .HasColumnName("type");
            entity.Property(e => e.Value)
                .HasMaxLength(255)
                .HasColumnName("value");
        });

        modelBuilder.Entity<Yv5w6h8fWcfmMarketplaceReviewsResponse>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_wcfm_marketplace_reviews_response");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20)")
                .HasColumnName("ID");
            entity.Property(e => e.AuthorEmail)
                .HasMaxLength(255)
                .HasColumnName("author_email");
            entity.Property(e => e.AuthorId)
                .HasColumnType("bigint(20)")
                .HasColumnName("author_id");
            entity.Property(e => e.AuthorName)
                .HasMaxLength(255)
                .HasColumnName("author_name");
            entity.Property(e => e.Posted)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("posted");
            entity.Property(e => e.Reply).HasColumnName("reply");
            entity.Property(e => e.ReplyBy)
                .HasColumnType("bigint(20)")
                .HasColumnName("reply_by");
            entity.Property(e => e.ReviewId)
                .HasColumnType("bigint(20)")
                .HasColumnName("review_id");
            entity.Property(e => e.VendorId)
                .HasColumnType("bigint(20)")
                .HasColumnName("vendor_id");
        });

        modelBuilder.Entity<Yv5w6h8fWcfmMarketplaceReviewsResponseMetum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_wcfm_marketplace_reviews_response_meta");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20)")
                .HasColumnName("ID");
            entity.Property(e => e.Key)
                .HasMaxLength(255)
                .HasColumnName("key");
            entity.Property(e => e.ReviewResponseId)
                .HasColumnType("bigint(20)")
                .HasColumnName("review_response_id");
            entity.Property(e => e.Value)
                .HasMaxLength(255)
                .HasColumnName("value");
        });

        modelBuilder.Entity<Yv5w6h8fWcfmMarketplaceShippingZoneLocation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_wcfm_marketplace_shipping_zone_locations");

            entity.Property(e => e.Id)
                .HasColumnType("int(11) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.LocationCode)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("location_code");
            entity.Property(e => e.LocationType)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("location_type");
            entity.Property(e => e.VendorId)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("vendor_id");
            entity.Property(e => e.ZoneId)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("zone_id");
        });

        modelBuilder.Entity<Yv5w6h8fWcfmMarketplaceShippingZoneMethod>(entity =>
        {
            entity.HasKey(e => e.InstanceId).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_wcfm_marketplace_shipping_zone_methods");

            entity.Property(e => e.InstanceId)
                .HasColumnType("int(11) unsigned")
                .HasColumnName("instance_id");
            entity.Property(e => e.IsEnabled)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("is_enabled");
            entity.Property(e => e.MethodId)
                .HasMaxLength(255)
                .HasDefaultValueSql("''''''")
                .HasColumnName("method_id");
            entity.Property(e => e.Settings)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("settings");
            entity.Property(e => e.VendorId)
                .HasColumnType("int(11)")
                .HasColumnName("vendor_id");
            entity.Property(e => e.ZoneId)
                .HasColumnType("int(11) unsigned")
                .HasColumnName("zone_id");
        });

        modelBuilder.Entity<Yv5w6h8fWcfmMarketplaceStoreTaxonomy>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_wcfm_marketplace_store_taxonomies");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20)")
                .HasColumnName("ID");
            entity.Property(e => e.Lang)
                .HasMaxLength(20)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("lang");
            entity.Property(e => e.Parent)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("parent");
            entity.Property(e => e.ProductId)
                .HasColumnType("bigint(20)")
                .HasColumnName("product_id");
            entity.Property(e => e.Taxonomy)
                .HasMaxLength(100)
                .HasColumnName("taxonomy");
            entity.Property(e => e.Term)
                .HasColumnType("bigint(20)")
                .HasColumnName("term");
            entity.Property(e => e.VendorId)
                .HasColumnType("bigint(20)")
                .HasColumnName("vendor_id");
        });

        modelBuilder.Entity<Yv5w6h8fWcfmMarketplaceVendorLedger>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_wcfm_marketplace_vendor_ledger");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20)")
                .HasColumnName("ID");
            entity.Property(e => e.Created)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("created");
            entity.Property(e => e.Credit)
                .HasMaxLength(100)
                .HasColumnName("credit");
            entity.Property(e => e.Debit)
                .HasMaxLength(100)
                .HasColumnName("debit");
            entity.Property(e => e.Reference)
                .HasMaxLength(100)
                .HasColumnName("reference");
            entity.Property(e => e.ReferenceDetails)
                .HasColumnType("text")
                .HasColumnName("reference_details");
            entity.Property(e => e.ReferenceId)
                .HasColumnType("bigint(20)")
                .HasColumnName("reference_id");
            entity.Property(e => e.ReferenceStatus)
                .HasMaxLength(100)
                .HasDefaultValueSql("'''pending'''")
                .HasColumnName("reference_status");
            entity.Property(e => e.ReferenceUpdateDate)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("reference_update_date");
            entity.Property(e => e.VendorId)
                .HasColumnType("bigint(20)")
                .HasColumnName("vendor_id");
        });

        modelBuilder.Entity<Yv5w6h8fWcfmMarketplaceWithdrawRequest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_wcfm_marketplace_withdraw_request");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20)")
                .HasColumnName("ID");
            entity.Property(e => e.CommissionIds)
                .HasDefaultValueSql("''''''")
                .HasColumnName("commission_ids");
            entity.Property(e => e.Created)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("created");
            entity.Property(e => e.IsAutoWithdrawal).HasColumnName("is_auto_withdrawal");
            entity.Property(e => e.OrderIds)
                .HasDefaultValueSql("''''''")
                .HasColumnName("order_ids");
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(255)
                .HasColumnName("payment_method");
            entity.Property(e => e.VendorId)
                .HasColumnType("bigint(20)")
                .HasColumnName("vendor_id");
            entity.Property(e => e.WithdrawAmount)
                .HasMaxLength(255)
                .HasDefaultValueSql("'''0'''")
                .HasColumnName("withdraw_amount");
            entity.Property(e => e.WithdrawCharges)
                .HasMaxLength(255)
                .HasDefaultValueSql("'''0'''")
                .HasColumnName("withdraw_charges");
            entity.Property(e => e.WithdrawMode)
                .HasMaxLength(100)
                .HasDefaultValueSql("'''by_request'''")
                .HasColumnName("withdraw_mode");
            entity.Property(e => e.WithdrawNote).HasColumnName("withdraw_note");
            entity.Property(e => e.WithdrawPaidDate)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("withdraw_paid_date");
            entity.Property(e => e.WithdrawStatus)
                .HasMaxLength(100)
                .HasDefaultValueSql("'''pending'''")
                .HasColumnName("withdraw_status");
        });

        modelBuilder.Entity<Yv5w6h8fWcfmMarketplaceWithdrawRequestMetum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_wcfm_marketplace_withdraw_request_meta");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20)")
                .HasColumnName("ID");
            entity.Property(e => e.Key)
                .HasMaxLength(255)
                .HasColumnName("key");
            entity.Property(e => e.Value)
                .HasMaxLength(255)
                .HasColumnName("value");
            entity.Property(e => e.WithdrawId)
                .HasColumnType("bigint(20)")
                .HasColumnName("withdraw_id");
        });

        modelBuilder.Entity<Yv5w6h8fWcfmMembershipSubscription>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_wcfm_membership_subscription");

            entity.HasIndex(e => new { e.VendorId, e.MembershipId, e.TransactionId, e.TransactionType }, "membership_subscription").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20)")
                .HasColumnName("ID");
            entity.Property(e => e.Created)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("created");
            entity.Property(e => e.Event)
                .HasMaxLength(50)
                .HasColumnName("event");
            entity.Property(e => e.MembershipId)
                .HasColumnType("bigint(20)")
                .HasColumnName("membership_id");
            entity.Property(e => e.PayMode)
                .HasMaxLength(50)
                .HasColumnName("pay_mode");
            entity.Property(e => e.SubscriptionAmt)
                .HasColumnType("int(10)")
                .HasColumnName("subscription_amt");
            entity.Property(e => e.SubscriptionInterval)
                .HasMaxLength(50)
                .HasColumnName("subscription_interval");
            entity.Property(e => e.SubscriptionType)
                .HasMaxLength(50)
                .HasColumnName("subscription_type");
            entity.Property(e => e.TransactionDetails)
                .HasColumnType("text")
                .HasColumnName("transaction_details");
            entity.Property(e => e.TransactionId)
                .HasMaxLength(100)
                .HasColumnName("transaction_id");
            entity.Property(e => e.TransactionStatus)
                .HasMaxLength(100)
                .HasColumnName("transaction_status");
            entity.Property(e => e.TransactionType)
                .HasMaxLength(100)
                .HasColumnName("transaction_type");
            entity.Property(e => e.VendorId)
                .HasColumnType("bigint(20)")
                .HasColumnName("vendor_id");
        });

        modelBuilder.Entity<Yv5w6h8fWcfmMessage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_wcfm_messages");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20)")
                .HasColumnName("ID");
            entity.Property(e => e.AuthorId)
                .HasColumnType("bigint(20)")
                .HasColumnName("author_id");
            entity.Property(e => e.AuthorIsAdmin).HasColumnName("author_is_admin");
            entity.Property(e => e.AuthorIsCustomer).HasColumnName("author_is_customer");
            entity.Property(e => e.AuthorIsVendor).HasColumnName("author_is_vendor");
            entity.Property(e => e.Created)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("created");
            entity.Property(e => e.IsDirectMessage).HasColumnName("is_direct_message");
            entity.Property(e => e.IsNotice).HasColumnName("is_notice");
            entity.Property(e => e.IsPined).HasColumnName("is_pined");
            entity.Property(e => e.Message).HasColumnName("message");
            entity.Property(e => e.MessageTo)
                .HasDefaultValueSql("'-1'")
                .HasColumnType("bigint(20)")
                .HasColumnName("message_to");
            entity.Property(e => e.MessageType)
                .HasMaxLength(100)
                .HasColumnName("message_type");
            entity.Property(e => e.ReplyTo)
                .HasColumnType("bigint(20)")
                .HasColumnName("reply_to");
        });

        modelBuilder.Entity<Yv5w6h8fWcfmMessagesModifier>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_wcfm_messages_modifier");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20)")
                .HasColumnName("ID");
            entity.Property(e => e.IsRead).HasColumnName("is_read");
            entity.Property(e => e.IsTrashed).HasColumnName("is_trashed");
            entity.Property(e => e.Message)
                .HasColumnType("bigint(20)")
                .HasColumnName("message");
            entity.Property(e => e.ReadBy)
                .HasColumnType("bigint(20)")
                .HasColumnName("read_by");
            entity.Property(e => e.ReadOn)
                .HasDefaultValueSql("'''0000-00-00 00:00:00'''")
                .HasColumnType("timestamp")
                .HasColumnName("read_on");
            entity.Property(e => e.TrashedBy)
                .HasColumnType("bigint(20)")
                .HasColumnName("trashed_by");
            entity.Property(e => e.TrashedOn)
                .HasDefaultValueSql("'''0000-00-00 00:00:00'''")
                .HasColumnType("timestamp")
                .HasColumnName("trashed_on");
        });

        modelBuilder.Entity<Yv5w6h8fWcfmMessagesStat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_wcfm_messages_stat");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20)")
                .HasColumnName("ID");
            entity.Property(e => e.DislikedBy)
                .HasColumnType("bigint(20)")
                .HasColumnName("disliked_by");
            entity.Property(e => e.DislikedOn)
                .HasDefaultValueSql("'''0000-00-00 00:00:00'''")
                .HasColumnType("timestamp")
                .HasColumnName("disliked_on");
            entity.Property(e => e.IsDisliked).HasColumnName("is_disliked");
            entity.Property(e => e.IsLiked).HasColumnName("is_liked");
            entity.Property(e => e.LikedBy)
                .HasColumnType("bigint(20)")
                .HasColumnName("liked_by");
            entity.Property(e => e.LikedOn)
                .HasDefaultValueSql("'''0000-00-00 00:00:00'''")
                .HasColumnType("timestamp")
                .HasColumnName("liked_on");
            entity.Property(e => e.Message)
                .HasColumnType("bigint(20)")
                .HasColumnName("message");
        });

        modelBuilder.Entity<Yv5w6h8fWcfmSupport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_wcfm_support");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20)")
                .HasColumnName("ID");
            entity.Property(e => e.AuthorId)
                .HasColumnType("bigint(20)")
                .HasColumnName("author_id");
            entity.Property(e => e.Category).HasColumnName("category");
            entity.Property(e => e.CustomerEmail)
                .HasMaxLength(200)
                .HasColumnName("customer_email");
            entity.Property(e => e.CustomerId)
                .HasColumnType("bigint(20)")
                .HasColumnName("customer_id");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(200)
                .HasColumnName("customer_name");
            entity.Property(e => e.ItemId)
                .HasColumnType("bigint(20)")
                .HasColumnName("item_id");
            entity.Property(e => e.OrderId)
                .HasColumnType("bigint(20)")
                .HasColumnName("order_id");
            entity.Property(e => e.Posted)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("posted");
            entity.Property(e => e.Priority)
                .HasMaxLength(200)
                .HasColumnName("priority");
            entity.Property(e => e.ProductId)
                .HasColumnType("bigint(20)")
                .HasColumnName("product_id");
            entity.Property(e => e.Query).HasColumnName("query");
            entity.Property(e => e.Status)
                .HasMaxLength(200)
                .HasColumnName("status");
            entity.Property(e => e.VendorId)
                .HasColumnType("bigint(20)")
                .HasColumnName("vendor_id");
        });

        modelBuilder.Entity<Yv5w6h8fWcfmSupportMetum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_wcfm_support_meta");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20)")
                .HasColumnName("ID");
            entity.Property(e => e.Key)
                .HasMaxLength(200)
                .HasColumnName("key");
            entity.Property(e => e.SupportId)
                .HasColumnType("bigint(20)")
                .HasColumnName("support_id");
            entity.Property(e => e.Type)
                .HasMaxLength(200)
                .HasColumnName("type");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<Yv5w6h8fWcfmSupportResponse>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_wcfm_support_response");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20)")
                .HasColumnName("ID");
            entity.Property(e => e.CustomerId)
                .HasColumnType("bigint(20)")
                .HasColumnName("customer_id");
            entity.Property(e => e.ItemId)
                .HasColumnType("bigint(20)")
                .HasColumnName("item_id");
            entity.Property(e => e.OrderId)
                .HasColumnType("bigint(20)")
                .HasColumnName("order_id");
            entity.Property(e => e.Posted)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("posted");
            entity.Property(e => e.ProductId)
                .HasColumnType("bigint(20)")
                .HasColumnName("product_id");
            entity.Property(e => e.Reply).HasColumnName("reply");
            entity.Property(e => e.ReplyBy)
                .HasColumnType("bigint(20)")
                .HasColumnName("reply_by");
            entity.Property(e => e.SupportId)
                .HasColumnType("bigint(20)")
                .HasColumnName("support_id");
            entity.Property(e => e.VendorId)
                .HasColumnType("bigint(20)")
                .HasColumnName("vendor_id");
        });

        modelBuilder.Entity<Yv5w6h8fWcfmSupportResponseMetum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_wcfm_support_response_meta");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20)")
                .HasColumnName("ID");
            entity.Property(e => e.Key)
                .HasMaxLength(200)
                .HasColumnName("key");
            entity.Property(e => e.SupportResponseId)
                .HasColumnType("bigint(20)")
                .HasColumnName("support_response_id");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<Yv5w6h8fWoocommerceApiKey>(entity =>
        {
            entity.HasKey(e => e.KeyId).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_woocommerce_api_keys");

            entity.HasIndex(e => e.ConsumerKey, "consumer_key");

            entity.HasIndex(e => e.ConsumerSecret, "consumer_secret");

            entity.Property(e => e.KeyId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("key_id");
            entity.Property(e => e.ConsumerKey)
                .HasMaxLength(64)
                .IsFixedLength()
                .HasColumnName("consumer_key");
            entity.Property(e => e.ConsumerSecret)
                .HasMaxLength(43)
                .IsFixedLength()
                .HasColumnName("consumer_secret");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("description");
            entity.Property(e => e.LastAccess)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("datetime")
                .HasColumnName("last_access");
            entity.Property(e => e.Nonces)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("nonces");
            entity.Property(e => e.Permissions)
                .HasMaxLength(10)
                .HasColumnName("permissions");
            entity.Property(e => e.TruncatedKey)
                .HasMaxLength(7)
                .IsFixedLength()
                .HasColumnName("truncated_key");
            entity.Property(e => e.UserId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<Yv5w6h8fWoocommerceAttributeTaxonomy>(entity =>
        {
            entity.HasKey(e => e.AttributeId).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_woocommerce_attribute_taxonomies");

            entity.HasIndex(e => e.AttributeName, "attribute_name");

            entity.Property(e => e.AttributeId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("attribute_id");
            entity.Property(e => e.AttributeLabel)
                .HasMaxLength(200)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("attribute_label");
            entity.Property(e => e.AttributeName)
                .HasMaxLength(200)
                .HasColumnName("attribute_name");
            entity.Property(e => e.AttributeOrderby)
                .HasMaxLength(20)
                .HasColumnName("attribute_orderby");
            entity.Property(e => e.AttributePublic)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(1)")
                .HasColumnName("attribute_public");
            entity.Property(e => e.AttributeType)
                .HasMaxLength(20)
                .HasColumnName("attribute_type");
        });

        modelBuilder.Entity<Yv5w6h8fWoocommerceDownloadableProductPermission>(entity =>
        {
            entity.HasKey(e => e.PermissionId).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_woocommerce_downloadable_product_permissions");

            entity.HasIndex(e => new { e.ProductId, e.OrderId, e.OrderKey, e.DownloadId }, "download_order_key_product");

            entity.HasIndex(e => new { e.DownloadId, e.OrderId, e.ProductId }, "download_order_product");

            entity.HasIndex(e => e.OrderId, "order_id");

            entity.HasIndex(e => new { e.UserId, e.OrderId, e.DownloadsRemaining, e.AccessExpires }, "user_order_remaining_expires");

            entity.Property(e => e.PermissionId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("permission_id");
            entity.Property(e => e.AccessExpires)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("datetime")
                .HasColumnName("access_expires");
            entity.Property(e => e.AccessGranted)
                .HasDefaultValueSql("'''0000-00-00 00:00:00'''")
                .HasColumnType("datetime")
                .HasColumnName("access_granted");
            entity.Property(e => e.DownloadCount)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("download_count");
            entity.Property(e => e.DownloadId)
                .HasMaxLength(36)
                .HasColumnName("download_id");
            entity.Property(e => e.DownloadsRemaining)
                .HasMaxLength(9)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("downloads_remaining");
            entity.Property(e => e.OrderId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("order_id");
            entity.Property(e => e.OrderKey)
                .HasMaxLength(200)
                .HasColumnName("order_key");
            entity.Property(e => e.ProductId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("product_id");
            entity.Property(e => e.UserEmail)
                .HasMaxLength(200)
                .HasColumnName("user_email");
            entity.Property(e => e.UserId)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<Yv5w6h8fWoocommerceLog>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_woocommerce_log");

            entity.HasIndex(e => e.Level, "level");

            entity.Property(e => e.LogId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("log_id");
            entity.Property(e => e.Context)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("context");
            entity.Property(e => e.Level)
                .HasColumnType("smallint(4)")
                .HasColumnName("level");
            entity.Property(e => e.Message).HasColumnName("message");
            entity.Property(e => e.Source)
                .HasMaxLength(200)
                .HasColumnName("source");
            entity.Property(e => e.Timestamp)
                .HasColumnType("datetime")
                .HasColumnName("timestamp");
        });

        modelBuilder.Entity<Yv5w6h8fWoocommerceOrderItem>(entity =>
        {
            entity.HasKey(e => e.OrderItemId).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_woocommerce_order_items");

            entity.HasIndex(e => e.OrderId, "order_id");

            entity.Property(e => e.OrderItemId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("order_item_id");
            entity.Property(e => e.OrderId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("order_id");
            entity.Property(e => e.OrderItemName)
                .HasColumnType("text")
                .HasColumnName("order_item_name");
            entity.Property(e => e.OrderItemType)
                .HasMaxLength(200)
                .HasDefaultValueSql("''''''")
                .HasColumnName("order_item_type");
        });

        modelBuilder.Entity<Yv5w6h8fWoocommerceOrderItemmetum>(entity =>
        {
            entity.HasKey(e => e.MetaId).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_woocommerce_order_itemmeta");

            entity.HasIndex(e => e.MetaKey, "meta_key");

            entity.HasIndex(e => e.OrderItemId, "order_item_id");

            entity.Property(e => e.MetaId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("meta_id");
            entity.Property(e => e.MetaKey)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("meta_key");
            entity.Property(e => e.MetaValue)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("meta_value");
            entity.Property(e => e.OrderItemId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("order_item_id");
        });

        modelBuilder.Entity<Yv5w6h8fWoocommercePaymentToken>(entity =>
        {
            entity.HasKey(e => e.TokenId).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_woocommerce_payment_tokens");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.TokenId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("token_id");
            entity.Property(e => e.GatewayId)
                .HasMaxLength(200)
                .HasColumnName("gateway_id");
            entity.Property(e => e.IsDefault).HasColumnName("is_default");
            entity.Property(e => e.Token)
                .HasColumnType("text")
                .HasColumnName("token");
            entity.Property(e => e.Type)
                .HasMaxLength(200)
                .HasColumnName("type");
            entity.Property(e => e.UserId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<Yv5w6h8fWoocommercePaymentTokenmetum>(entity =>
        {
            entity.HasKey(e => e.MetaId).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_woocommerce_payment_tokenmeta");

            entity.HasIndex(e => e.MetaKey, "meta_key");

            entity.HasIndex(e => e.PaymentTokenId, "payment_token_id");

            entity.Property(e => e.MetaId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("meta_id");
            entity.Property(e => e.MetaKey)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("meta_key");
            entity.Property(e => e.MetaValue)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("meta_value");
            entity.Property(e => e.PaymentTokenId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("payment_token_id");
        });

        modelBuilder.Entity<Yv5w6h8fWoocommerceSession>(entity =>
        {
            entity.HasKey(e => e.SessionId).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_woocommerce_sessions");

            entity.HasIndex(e => e.SessionKey, "session_key").IsUnique();

            entity.Property(e => e.SessionId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("session_id");
            entity.Property(e => e.SessionExpiry)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("session_expiry");
            entity.Property(e => e.SessionKey)
                .HasMaxLength(32)
                .IsFixedLength()
                .HasColumnName("session_key");
            entity.Property(e => e.SessionValue).HasColumnName("session_value");
        });

        modelBuilder.Entity<Yv5w6h8fWoocommerceShippingZone>(entity =>
        {
            entity.HasKey(e => e.ZoneId).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_woocommerce_shipping_zones");

            entity.Property(e => e.ZoneId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("zone_id");
            entity.Property(e => e.ZoneName)
                .HasMaxLength(200)
                .HasColumnName("zone_name");
            entity.Property(e => e.ZoneOrder)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("zone_order");
        });

        modelBuilder.Entity<Yv5w6h8fWoocommerceShippingZoneLocation>(entity =>
        {
            entity.HasKey(e => e.LocationId).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_woocommerce_shipping_zone_locations");

            entity.HasIndex(e => new { e.LocationType, e.LocationCode }, "location_type_code");

            entity.HasIndex(e => e.ZoneId, "zone_id");

            entity.Property(e => e.LocationId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("location_id");
            entity.Property(e => e.LocationCode)
                .HasMaxLength(200)
                .HasColumnName("location_code");
            entity.Property(e => e.LocationType)
                .HasMaxLength(40)
                .HasColumnName("location_type");
            entity.Property(e => e.ZoneId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("zone_id");
        });

        modelBuilder.Entity<Yv5w6h8fWoocommerceShippingZoneMethod>(entity =>
        {
            entity.HasKey(e => e.InstanceId).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_woocommerce_shipping_zone_methods");

            entity.Property(e => e.InstanceId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("instance_id");
            entity.Property(e => e.IsEnabled)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("is_enabled");
            entity.Property(e => e.MethodId)
                .HasMaxLength(200)
                .HasColumnName("method_id");
            entity.Property(e => e.MethodOrder)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("method_order");
            entity.Property(e => e.ZoneId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("zone_id");
        });

        modelBuilder.Entity<Yv5w6h8fWoocommerceTaxRate>(entity =>
        {
            entity.HasKey(e => e.TaxRateId).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_woocommerce_tax_rates");

            entity.HasIndex(e => e.TaxRateClass, "tax_rate_class");

            entity.HasIndex(e => e.TaxRateCountry, "tax_rate_country");

            entity.HasIndex(e => e.TaxRatePriority, "tax_rate_priority");

            entity.HasIndex(e => e.TaxRateState, "tax_rate_state");

            entity.Property(e => e.TaxRateId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("tax_rate_id");
            entity.Property(e => e.TaxRate)
                .HasMaxLength(8)
                .HasDefaultValueSql("''''''")
                .HasColumnName("tax_rate");
            entity.Property(e => e.TaxRateClass)
                .HasMaxLength(200)
                .HasDefaultValueSql("''''''")
                .HasColumnName("tax_rate_class");
            entity.Property(e => e.TaxRateCompound)
                .HasColumnType("int(1)")
                .HasColumnName("tax_rate_compound");
            entity.Property(e => e.TaxRateCountry)
                .HasMaxLength(2)
                .HasDefaultValueSql("''''''")
                .HasColumnName("tax_rate_country");
            entity.Property(e => e.TaxRateName)
                .HasMaxLength(200)
                .HasDefaultValueSql("''''''")
                .HasColumnName("tax_rate_name");
            entity.Property(e => e.TaxRateOrder)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("tax_rate_order");
            entity.Property(e => e.TaxRatePriority)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("tax_rate_priority");
            entity.Property(e => e.TaxRateShipping)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(1)")
                .HasColumnName("tax_rate_shipping");
            entity.Property(e => e.TaxRateState)
                .HasMaxLength(200)
                .HasDefaultValueSql("''''''")
                .HasColumnName("tax_rate_state");
        });

        modelBuilder.Entity<Yv5w6h8fWoocommerceTaxRateLocation>(entity =>
        {
            entity.HasKey(e => e.LocationId).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_woocommerce_tax_rate_locations");

            entity.HasIndex(e => new { e.LocationType, e.LocationCode }, "location_type_code");

            entity.HasIndex(e => e.TaxRateId, "tax_rate_id");

            entity.Property(e => e.LocationId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("location_id");
            entity.Property(e => e.LocationCode)
                .HasMaxLength(200)
                .HasColumnName("location_code");
            entity.Property(e => e.LocationType)
                .HasMaxLength(40)
                .HasColumnName("location_type");
            entity.Property(e => e.TaxRateId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("tax_rate_id");
        });

        modelBuilder.Entity<Yv5w6h8fWpfFilter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_wpf_filters");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.MetaKeys)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("meta_keys");
            entity.Property(e => e.SettingData)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("mediumtext")
                .HasColumnName("setting_data");
            entity.Property(e => e.Title)
                .HasMaxLength(128)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("title");
        });

        modelBuilder.Entity<Yv5w6h8fWpfMetaKey>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_wpf_meta_keys");

            entity.HasIndex(e => e.MetaKey, "meta_key").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Added)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("added");
            entity.Property(e => e.Calculated)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("calculated");
            entity.Property(e => e.Locked)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("locked");
            entity.Property(e => e.MetaKey).HasColumnName("meta_key");
            entity.Property(e => e.MetaLike)
                .HasColumnType("smallint(3)")
                .HasColumnName("meta_like");
            entity.Property(e => e.MetaMode)
                .HasColumnType("smallint(3)")
                .HasColumnName("meta_mode");
            entity.Property(e => e.MetaType)
                .HasColumnType("smallint(3)")
                .HasColumnName("meta_type");
            entity.Property(e => e.Parent)
                .HasColumnType("int(11)")
                .HasColumnName("parent");
            entity.Property(e => e.Status)
                .HasColumnType("smallint(3)")
                .HasColumnName("status");
            entity.Property(e => e.Taxonomy)
                .HasMaxLength(255)
                .HasColumnName("taxonomy");
            entity.Property(e => e.Updated)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("updated");
        });

        modelBuilder.Entity<Yv5w6h8fWpfMetaValue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_wpf_meta_values");

            entity.HasIndex(e => new { e.KeyId, e.Value }, "i_key");

            entity.HasIndex(e => new { e.KeyId, e.Key2, e.Key3, e.Key4, e.Value }, "uniq_key").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20)")
                .HasColumnName("id");
            entity.Property(e => e.Key2)
                .HasMaxLength(32)
                .HasColumnName("key2");
            entity.Property(e => e.Key3)
                .HasMaxLength(32)
                .HasColumnName("key3");
            entity.Property(e => e.Key4)
                .HasMaxLength(32)
                .HasColumnName("key4");
            entity.Property(e => e.KeyId)
                .HasColumnType("int(11)")
                .HasColumnName("key_id");
            entity.Property(e => e.ProductCnt)
                .HasColumnType("int(11)")
                .HasColumnName("product_cnt");
            entity.Property(e => e.Value)
                .HasMaxLength(150)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("value");
            entity.Property(e => e.VariationCnt)
                .HasColumnType("int(11)")
                .HasColumnName("variation_cnt");
        });

        modelBuilder.Entity<Yv5w6h8fWpfMetaValuesBk>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("yv5w6h8f_wpf_meta_values_bk");

            entity.HasIndex(e => e.KeyId, "key_id");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20)")
                .HasColumnName("id");
            entity.Property(e => e.Key2)
                .HasMaxLength(32)
                .HasColumnName("key2");
            entity.Property(e => e.Key3)
                .HasMaxLength(32)
                .HasColumnName("key3");
            entity.Property(e => e.Key4)
                .HasMaxLength(32)
                .HasColumnName("key4");
            entity.Property(e => e.KeyId)
                .HasColumnType("int(11)")
                .HasColumnName("key_id");
            entity.Property(e => e.Value)
                .HasMaxLength(150)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("value");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
