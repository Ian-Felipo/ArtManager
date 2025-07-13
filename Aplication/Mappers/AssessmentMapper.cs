using ArtManager.Domain.Entities;
using ArtManager.Aplication.DTOs;

namespace ArtManager.Aplication.Mappers;

public static class AssessmentMapper
{
    public static Assessment AssessmentRequestToAssessment(this AssessmentRequest assessmentRequest)
    {
        return new Assessment(assessmentRequest.Title, assessmentRequest.Note, assessmentRequest.Comment, assessmentRequest.UserId, assessmentRequest.ArtistId);
    }

    public static AssessmentResponse AssessmentToAssessmentResponse(this Assessment assessment)
    {
        return new AssessmentResponse()
        {
            Id = assessment.Id,
            Title = assessment.Title,
            Note = assessment.Note,
            UserId = assessment.UserId,
            ArtistId = assessment.ArtistId
        };
    }
}