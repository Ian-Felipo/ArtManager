using ArtManager.Aplication.DTOs;

namespace ArtManager.Aplication.Interfaces;

public interface IAssessmentService
{
    IEnumerable<AssessmentResponse> FindAllAssessments();
    AssessmentResponse FindAssessmentById(AssessmentRequest assessmentRequest);
    AssessmentResponse FindAssessmentByName(AssessmentRequest assessmentRequest);
    AssessmentResponse CreateAssessment(AssessmentRequest assessmentRequest);
    AssessmentResponse UpdateAssessment(AssessmentRequest assessmentRequest);
    AssessmentResponse RemoveAssessment(AssessmentRequest assessmentRequest);
}