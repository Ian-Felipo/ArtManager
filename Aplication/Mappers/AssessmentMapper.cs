using ArtManager.Domain.Entities;
using ArtManager.Aplication.DTOs;

namespace ArtManager.Aplication.Mappers;

public static class AssessmentMapper
{
    public static Assessment ToAssessment(this AssessmentRequest assessmentRequest, int id = 0)
    {
        return new Assessment
        (
            id,
            assessmentRequest.Title,
            assessmentRequest.Note,
            assessmentRequest.Comment,
            assessmentRequest.UserId,
            assessmentRequest.ArtistId
        );
    }

    public static AssessmentResponse ToAssessmentResponse(this Assessment assessment)
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