﻿// ******************************************************************************
//  © 2019 Sebastiaan Dammann | damsteen.nl
// 
//  File:           : GetParticipantsInfoQueryHandlerTests.cs
//  Project         : PokerTime.Application.Tests.Unit
// ******************************************************************************

namespace PokerTime.Application.Tests.Unit.Sessions.Queries {
    using System.Drawing;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using Application.Sessions.Queries.GetParticipantsInfo;
    using Domain.Entities;
    using NUnit.Framework;
    using Support;

    [TestFixture]
    public sealed class GetParticipantsInfoQueryHandlerTests : QueryTestBase {
        [Test]
        public async Task GetParticipantsInfoCommand_ReturnsEmptyList_OnRetrospectiveNotFound() {
            // Given
            const string sessionId = "surely-not-found";
            var query = new GetParticipantsInfoQuery(sessionId);
            var handler = new GetParticipantsInfoQueryHandler(this.Context, this.Mapper);

            // When
            var result = await handler.Handle(query, CancellationToken.None);

            // Then
            Assert.That(result.Participants, Is.Empty);
        }

        [Test]
        public async Task GetParticipantsInfoCommand_ReturnsList_OnRetrospectiveFound() {
            // Given
            var retro = new Session {
                Title = "What",
                Participants =
                {
                    new Participant {Name = "John", Color = Color.BlueViolet},
                    new Participant {Name = "Jane", Color = Color.Aqua},
                },
                HashedPassphrase = "abef"
            };
            string sessionId = retro.UrlId.StringId;
            this.Context.Sessions.Add(retro);
            await this.Context.SaveChangesAsync(CancellationToken.None);

            var query = new GetParticipantsInfoQuery(sessionId);
            var handler = new GetParticipantsInfoQueryHandler(this.Context, this.Mapper);

            // When
            var result = await handler.Handle(query, CancellationToken.None);

            // Then
            Assert.That(result.Participants, Is.Not.Empty);
            Assert.That(result.Participants.Select(x => x.Name), Contains.Item("John"));
            Assert.That(result.Participants.Select(x => x.Name), Contains.Item("Jane"));
        }
    }
}
