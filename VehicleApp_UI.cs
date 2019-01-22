@model VehicalApp.VehicInfo

@{
    ViewData["Title"] = "Create";
}

<h2>Create</h2>

<h4>VehicInfo</h4>
<hr />
<div class="row">
    <div class="col-md-4">
        <form asp-action="Create">
            <div asp-validation-summary="ModelOnly" class="text-danger"></div>
            <div class="form-group">
                <label asp-for="VehCategs" class="control-label"></label>
                <select asp-for="VehCategs" asp-items="Html.GetEnumSelectList<VehCate>()" class ="form-control"></select>
                <span asp-validation-for="VehCategs" class="text-danger"></span>
            </div>
            <div class="form-group">
                <label asp-for="TypeC" class="control-label"></label>
                <select asp-for="TypeC" asp-items="Html.GetEnumSelectList<VehType>()"class ="form-control"></select>
                <span asp-validation-for="TypeC" class="text-danger"></span>
            </div>
            <div class="form-group">
                <label asp-for="Make" class="control-label"></label>
                <select asp-for="Make" asp-items="Html.GetEnumSelectList<VehMake>()"class="form-control"></select>
                <span asp-validation-for="Make" class="text-danger"></span>
            </div>
            <div class="form-group">
                <label asp-for="Model" class="control-label"></label>
                <input asp-for="Model" class="form-control" />
                <span asp-validation-for="Model" class="text-danger"></span>
            </div>
            <div class="form-group">
                <label asp-for="Color" class="control-label"></label>
                <select asp-for="Color" asp-items="Html.GetEnumSelectList<VehColor>()"class="form-control"></select>
                <span asp-validation-for="Color" class="text-danger"></span>
            </div>
            <div class="form-group">
                <label asp-for="CusName" class="control-label"></label>
                <input asp-for="CusName" class="form-control" />
                <span asp-validation-for="CusName" class="text-danger"></span>
            </div>
            <div class="form-group">
                <label asp-for="Budget" class="control-label"></label>
                <input asp-for="Budget" class="form-control" />
                <span asp-validation-for="Budget" class="text-danger"></span>
            </div>
            <div class="form-group">
                <input type="submit" value="Create" class="btn btn-default" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action="Index">Back to List</a>
</div>

@section Scripts {
    @{await Html.RenderPartialAsync("_ValidationScriptsPartial");}
}
