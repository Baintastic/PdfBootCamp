  using System;
  using System.Collections.Generic;
  using System.Text.RegularExpressions;
  using Com.Aspose.PDF;
  using Com.Aspose.PDF.Model;
  namespace Com.Aspose.PDF.Api {
    public class PdfApi {
      string basePath;
      private readonly ApiInvoker apiInvoker = ApiInvoker.GetInstance();

      public PdfApi(String apiKey, String appSid, String basePath )
      {
	apiInvoker.apiKey = apiKey;
        apiInvoker.appSid = appSid;
        this.basePath = basePath;
      }

      public ApiInvoker getInvoker() {
        return apiInvoker;
      }

      // Sets the endpoint base url for the services being accessed
      public void setBasePath(string basePath) {
        this.basePath = basePath;
      }

      // Gets the endpoint base url for the services being accessed
      public String getBasePath() {
        return basePath;
      }

      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="pageNumber"></param>
      /// <param name="annotationNumber"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public AnnotationResponse GetPageAnnotation (string name, int? pageNumber, int? annotationNumber, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/pdf/{name}/pages/{pageNumber}/annotations/{annotationNumber}/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || pageNumber == null || annotationNumber == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (pageNumber == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])pageNumber=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "pageNumber" + "}", apiInvoker.ToPathValue(pageNumber)); 
		}
        if (annotationNumber == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])annotationNumber=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "annotationNumber" + "}", apiInvoker.ToPathValue(annotationNumber)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(AnnotationResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (AnnotationResponse) ApiInvoker.deserialize(response, typeof(AnnotationResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (AnnotationResponse) ApiInvoker.deserialize(response, typeof(AnnotationResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="pageNumber"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public AnnotationsResponse GetPageAnnotations (string name, int? pageNumber, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/pdf/{name}/pages/{pageNumber}/annotations/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || pageNumber == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (pageNumber == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])pageNumber=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "pageNumber" + "}", apiInvoker.ToPathValue(pageNumber)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(AnnotationsResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (AnnotationsResponse) ApiInvoker.deserialize(response, typeof(AnnotationsResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (AnnotationsResponse) ApiInvoker.deserialize(response, typeof(AnnotationsResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="attachmentIndex"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public AttachmentResponse GetDocumentAttachmentByIndex (string name, int? attachmentIndex, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/pdf/{name}/attachments/{attachmentIndex}/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || attachmentIndex == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (attachmentIndex == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])attachmentIndex=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "attachmentIndex" + "}", apiInvoker.ToPathValue(attachmentIndex)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(AttachmentResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (AttachmentResponse) ApiInvoker.deserialize(response, typeof(AttachmentResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (AttachmentResponse) ApiInvoker.deserialize(response, typeof(AttachmentResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public AttachmentsResponse GetDocumentAttachments (string name, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/pdf/{name}/attachments/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(AttachmentsResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (AttachmentsResponse) ApiInvoker.deserialize(response, typeof(AttachmentsResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (AttachmentsResponse) ApiInvoker.deserialize(response, typeof(AttachmentsResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="attachmentIndex"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public ResponseMessage GetDownloadDocumentAttachmentByIndex (string name, int? attachmentIndex, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/pdf/{name}/attachments/{attachmentIndex}/download/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || attachmentIndex == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (attachmentIndex == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])attachmentIndex=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "attachmentIndex" + "}", apiInvoker.ToPathValue(attachmentIndex)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(ResponseMessage) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (ResponseMessage) ApiInvoker.deserialize(response, typeof(ResponseMessage));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (ResponseMessage) ApiInvoker.deserialize(response, typeof(ResponseMessage));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="pageNumber"></param>
      /// <param name="imageNumber"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public BarcodeResponseList GetExtractBarcodes (string name, int? pageNumber, int? imageNumber, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/pdf/{name}/pages/{pageNumber}/images/{imageNumber}/recognize/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || pageNumber == null || imageNumber == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (pageNumber == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])pageNumber=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "pageNumber" + "}", apiInvoker.ToPathValue(pageNumber)); 
		}
        if (imageNumber == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])imageNumber=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "imageNumber" + "}", apiInvoker.ToPathValue(imageNumber)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(BarcodeResponseList) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (BarcodeResponseList) ApiInvoker.deserialize(response, typeof(BarcodeResponseList));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (BarcodeResponseList) ApiInvoker.deserialize(response, typeof(BarcodeResponseList));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public BookmarksResponse GetDocumentBookmarks (string name, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/pdf/{name}/bookmarks/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(BookmarksResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (BookmarksResponse) ApiInvoker.deserialize(response, typeof(BookmarksResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (BookmarksResponse) ApiInvoker.deserialize(response, typeof(BookmarksResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="bookmarkPath"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public ResponseMessage GetDocumentBookmarksChildren (string name, string bookmarkPath, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/pdf/{name}/bookmarks/{bookmarkPath}/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (bookmarkPath == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])bookmarkPath=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "bookmarkPath" + "}", apiInvoker.ToPathValue(bookmarkPath)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(ResponseMessage) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (ResponseMessage) ApiInvoker.deserialize(response, typeof(ResponseMessage));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (ResponseMessage) ApiInvoker.deserialize(response, typeof(ResponseMessage));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public ResponseMessage GetDocument (string name, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/pdf/{name}/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(ResponseMessage) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (ResponseMessage) ApiInvoker.deserialize(response, typeof(ResponseMessage));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (ResponseMessage) ApiInvoker.deserialize(response, typeof(ResponseMessage));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="format"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <param name="outPath"></param>
      /// <returns></returns>
      public ResponseMessage GetDocumentWithFormat (string name, string format, string storage, string folder, string outPath) {
        // create path and map variables
        var ResourcePath = "/pdf/{name}/?appSid={appSid}&amp;toFormat={toFormat}&amp;storage={storage}&amp;folder={folder}&amp;outPath={outPath}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || format == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (format == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])format=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "format" + "}", apiInvoker.ToPathValue(format)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        if (outPath == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])outPath=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "outPath" + "}", apiInvoker.ToPathValue(outPath)); 
		}
        try {
          if (typeof(ResponseMessage) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (ResponseMessage) ApiInvoker.deserialize(response, typeof(ResponseMessage));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (ResponseMessage) ApiInvoker.deserialize(response, typeof(ResponseMessage));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <param name="body"></param>
      /// <returns></returns>
      public SaaSposeResponse PostSignDocument (string name, string storage, string folder, Signature body) {
        // create path and map variables
        var ResourcePath = "/pdf/{name}/sign/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || body == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(SaaSposeResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "POST", queryParams, null, headerParams, formParams);
            return (SaaSposeResponse) ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, body, headerParams, formParams);
            if(response != null){
               return (SaaSposeResponse) ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="format"></param>
      /// <param name="from"></param>
      /// <param name="to"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public SplitResultResponse PostSplitDocument (string name, string format, int? from, int? to, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/pdf/{name}/split/?appSid={appSid}&amp;toFormat={toFormat}&amp;from={from}&amp;to={to}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (format == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])format=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "format" + "}", apiInvoker.ToPathValue(format)); 
		}
        if (from == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])from=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "from" + "}", apiInvoker.ToPathValue(from)); 
		}
        if (to == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])to=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "to" + "}", apiInvoker.ToPathValue(to)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(SplitResultResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "POST", queryParams, null, headerParams, formParams);
            return (SplitResultResponse) ApiInvoker.deserialize(response, typeof(SplitResultResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, null, headerParams, formParams);
            if(response != null){
               return (SplitResultResponse) ApiInvoker.deserialize(response, typeof(SplitResultResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="format"></param>
      /// <param name="url"></param>
      /// <param name="outPath"></param>
      /// <param name="file"></param>
      /// <returns></returns>
      public ResponseMessage PutConvertDocument (string format, string url, string outPath, byte[] file) {
        // create path and map variables
        var ResourcePath = "/pdf/convert/?appSid={appSid}&amp;toFormat={toFormat}&amp;url={url}&amp;outPath={outPath}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        //if (file == null ) {
        //   throw new ApiException(400, "missing required params");
        //}
        if (format == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])format=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "format" + "}", apiInvoker.ToPathValue(format)); 
		}
        if (url == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])url=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "url" + "}", apiInvoker.ToPathValue(url)); 
		}
        if (outPath == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])outPath=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "outPath" + "}", apiInvoker.ToPathValue(outPath)); 
		}
        if (file != null){
         if(file is byte[]) {
		 
			 var docFile = new FileInfo();
             docFile.file = file;
             docFile.MimeType = "application/octet-stream";
             formParams.Add("file", docFile);
         } else {
           //string paramStr = (file is DateTime) ? ((DateTime)(object)file).ToString("u") : Convert.ToString(file);
		    string paramStr = Convert.ToString(file);
           formParams.Add("file", paramStr);
         }
		}
        try {
          if (typeof(ResponseMessage) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "PUT", queryParams, null, headerParams, formParams);
            return (ResponseMessage) ApiInvoker.deserialize(response, typeof(ResponseMessage));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "PUT", queryParams, null, headerParams, formParams);
            if(response != null){
               return (ResponseMessage) ApiInvoker.deserialize(response, typeof(ResponseMessage));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="templateFile"></param>
      /// <param name="dataFile"></param>
      /// <param name="templateType"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public DocumentResponse PutCreateDocument (string name, string templateFile, string dataFile, string templateType, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/pdf/{name}/?appSid={appSid}&amp;templateFile={templateFile}&amp;dataFile={dataFile}&amp;templateType={templateType}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (templateFile == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])templateFile=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "templateFile" + "}", apiInvoker.ToPathValue(templateFile)); 
		}
        if (dataFile == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])dataFile=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "dataFile" + "}", apiInvoker.ToPathValue(dataFile)); 
		}
        if (templateType == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])templateType=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "templateType" + "}", apiInvoker.ToPathValue(templateType)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(DocumentResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "PUT", queryParams, null, headerParams, formParams);
            return (DocumentResponse) ApiInvoker.deserialize(response, typeof(DocumentResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "PUT", queryParams, null, headerParams, formParams);
            if(response != null){
               return (DocumentResponse) ApiInvoker.deserialize(response, typeof(DocumentResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="appendFile"></param>
      /// <param name="startPage"></param>
      /// <param name="endPage"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <param name="body"></param>
      /// <returns></returns>
      public DocumentResponse PostAppendDocument (string name, string appendFile, int? startPage, int? endPage, string storage, string folder, AppendDocument body) {
        // create path and map variables
        var ResourcePath = "/pdf/{name}/appendDocument/?appSid={appSid}&amp;appendFile={appendFile}&amp;startPage={startPage}&amp;endPage={endPage}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || body == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (appendFile == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])appendFile=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "appendFile" + "}", apiInvoker.ToPathValue(appendFile)); 
		}
        if (startPage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])startPage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "startPage" + "}", apiInvoker.ToPathValue(startPage)); 
		}
        if (endPage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])endPage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "endPage" + "}", apiInvoker.ToPathValue(endPage)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(DocumentResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "POST", queryParams, null, headerParams, formParams);
            return (DocumentResponse) ApiInvoker.deserialize(response, typeof(DocumentResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, body, headerParams, formParams);
            if(response != null){
               return (DocumentResponse) ApiInvoker.deserialize(response, typeof(DocumentResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <param name="body"></param>
      /// <returns></returns>
      public DocumentResponse PutMergeDocuments (string name, string storage, string folder, MergeDocuments body) {
        // create path and map variables
        var ResourcePath = "/pdf/{name}/merge/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || body == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(DocumentResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "PUT", queryParams, null, headerParams, formParams);
            return (DocumentResponse) ApiInvoker.deserialize(response, typeof(DocumentResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "PUT", queryParams, body, headerParams, formParams);
            if(response != null){
               return (DocumentResponse) ApiInvoker.deserialize(response, typeof(DocumentResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="resultFile"></param>
      /// <param name="brightness"></param>
      /// <param name="compression"></param>
      /// <param name="colorDepth"></param>
      /// <param name="leftMargin"></param>
      /// <param name="rightMargin"></param>
      /// <param name="topMargin"></param>
      /// <param name="bottomMargin"></param>
      /// <param name="orientation"></param>
      /// <param name="skipBlankPages"></param>
      /// <param name="width"></param>
      /// <param name="height"></param>
      /// <param name="xResolution"></param>
      /// <param name="yResolution"></param>
      /// <param name="pageIndex"></param>
      /// <param name="pageCount"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <param name="body"></param>
      /// <returns></returns>
      public SaaSposeResponse PutDocumentSaveAsTiff (string name, string resultFile, float? brightness, string compression, string colorDepth, int? leftMargin, int? rightMargin, int? topMargin, int? bottomMargin, string orientation, bool? skipBlankPages, int? width, int? height, int? xResolution, int? yResolution, int? pageIndex, int? pageCount, string storage, string folder, TiffExportOptions body) {
        // create path and map variables
        var ResourcePath = "/pdf/{name}/SaveAs/tiff/?appSid={appSid}&amp;resultFile={resultFile}&amp;brightness={brightness}&amp;compression={compression}&amp;colorDepth={colorDepth}&amp;leftMargin={leftMargin}&amp;rightMargin={rightMargin}&amp;topMargin={topMargin}&amp;bottomMargin={bottomMargin}&amp;orientation={orientation}&amp;skipBlankPages={skipBlankPages}&amp;width={width}&amp;height={height}&amp;xResolution={xResolution}&amp;yResolution={yResolution}&amp;pageIndex={pageIndex}&amp;pageCount={pageCount}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || body == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (resultFile == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])resultFile=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "resultFile" + "}", apiInvoker.ToPathValue(resultFile)); 
		}
        if (brightness == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])brightness=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "brightness" + "}", apiInvoker.ToPathValue(brightness)); 
		}
        if (compression == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])compression=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "compression" + "}", apiInvoker.ToPathValue(compression)); 
		}
        if (colorDepth == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])colorDepth=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "colorDepth" + "}", apiInvoker.ToPathValue(colorDepth)); 
		}
        if (leftMargin == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])leftMargin=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "leftMargin" + "}", apiInvoker.ToPathValue(leftMargin)); 
		}
        if (rightMargin == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])rightMargin=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "rightMargin" + "}", apiInvoker.ToPathValue(rightMargin)); 
		}
        if (topMargin == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])topMargin=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "topMargin" + "}", apiInvoker.ToPathValue(topMargin)); 
		}
        if (bottomMargin == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])bottomMargin=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "bottomMargin" + "}", apiInvoker.ToPathValue(bottomMargin)); 
		}
        if (orientation == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])orientation=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "orientation" + "}", apiInvoker.ToPathValue(orientation)); 
		}
        if (skipBlankPages == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])skipBlankPages=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "skipBlankPages" + "}", apiInvoker.ToPathValue(skipBlankPages)); 
		}
        if (width == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])width=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "width" + "}", apiInvoker.ToPathValue(width)); 
		}
        if (height == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])height=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "height" + "}", apiInvoker.ToPathValue(height)); 
		}
        if (xResolution == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])xResolution=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "xResolution" + "}", apiInvoker.ToPathValue(xResolution)); 
		}
        if (yResolution == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])yResolution=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "yResolution" + "}", apiInvoker.ToPathValue(yResolution)); 
		}
        if (pageIndex == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])pageIndex=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "pageIndex" + "}", apiInvoker.ToPathValue(pageIndex)); 
		}
        if (pageCount == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])pageCount=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "pageCount" + "}", apiInvoker.ToPathValue(pageCount)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(SaaSposeResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "PUT", queryParams, null, headerParams, formParams);
            return (SaaSposeResponse) ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "PUT", queryParams, body, headerParams, formParams);
            if(response != null){
               return (SaaSposeResponse) ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="fieldName"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public FieldResponse GetField (string name, string fieldName, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/pdf/{name}/fields/{fieldName}/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || fieldName == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (fieldName == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])fieldName=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "fieldName" + "}", apiInvoker.ToPathValue(fieldName)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(FieldResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (FieldResponse) ApiInvoker.deserialize(response, typeof(FieldResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (FieldResponse) ApiInvoker.deserialize(response, typeof(FieldResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public FieldsResponse GetFields (string name, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/pdf/{name}/fields/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(FieldsResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (FieldsResponse) ApiInvoker.deserialize(response, typeof(FieldsResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (FieldsResponse) ApiInvoker.deserialize(response, typeof(FieldsResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="page"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <param name="body"></param>
      /// <returns></returns>
      public SaaSposeResponse PostCreateField (string name, int? page, string storage, string folder, Field body) {
        // create path and map variables
        var ResourcePath = "/pdf/{name}/fields/?appSid={appSid}&amp;page={page}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || page == null || body == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (page == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])page=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "page" + "}", apiInvoker.ToPathValue(page)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(SaaSposeResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "POST", queryParams, null, headerParams, formParams);
            return (SaaSposeResponse) ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, body, headerParams, formParams);
            if(response != null){
               return (SaaSposeResponse) ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <param name="fieldName"></param>
      /// <param name="body"></param>
      /// <returns></returns>
      public FieldResponse PutUpdateField (string name, string storage, string folder, string fieldName, Field body) {
        // create path and map variables
        var ResourcePath = "/pdf/{name}/fields/{fieldName}/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || fieldName == null || body == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        if (fieldName == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])fieldName=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "fieldName" + "}", apiInvoker.ToPathValue(fieldName)); 
		}
        try {
          if (typeof(FieldResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "PUT", queryParams, null, headerParams, formParams);
            return (FieldResponse) ApiInvoker.deserialize(response, typeof(FieldResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "PUT", queryParams, body, headerParams, formParams);
            if(response != null){
               return (FieldResponse) ApiInvoker.deserialize(response, typeof(FieldResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <param name="body"></param>
      /// <returns></returns>
      public FieldsResponse PutUpdateFields (string name, string storage, string folder, Fields body) {
        // create path and map variables
        var ResourcePath = "/pdf/{name}/fields/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || body == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(FieldsResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "PUT", queryParams, null, headerParams, formParams);
            return (FieldsResponse) ApiInvoker.deserialize(response, typeof(FieldsResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "PUT", queryParams, body, headerParams, formParams);
            if(response != null){
               return (FieldsResponse) ApiInvoker.deserialize(response, typeof(FieldsResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="pageNumber"></param>
      /// <param name="fragmentNumber"></param>
      /// <param name="withEmpty"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public TextItemsResponse GetFragment (string name, int? pageNumber, int? fragmentNumber, string withEmpty, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/pdf/{name}/pages/{pageNumber}/fragments/{fragmentNumber}/?appSid={appSid}&amp;withEmpty={withEmpty}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || pageNumber == null || fragmentNumber == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (pageNumber == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])pageNumber=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "pageNumber" + "}", apiInvoker.ToPathValue(pageNumber)); 
		}
        if (fragmentNumber == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])fragmentNumber=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "fragmentNumber" + "}", apiInvoker.ToPathValue(fragmentNumber)); 
		}
        if (withEmpty == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])withEmpty=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "withEmpty" + "}", apiInvoker.ToPathValue(withEmpty)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(TextItemsResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (TextItemsResponse) ApiInvoker.deserialize(response, typeof(TextItemsResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (TextItemsResponse) ApiInvoker.deserialize(response, typeof(TextItemsResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="pageNumber"></param>
      /// <param name="withEmpty"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public TextItemsResponse GetFragments (string name, int? pageNumber, string withEmpty, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/pdf/{name}/pages/{pageNumber}/fragments/?appSid={appSid}&amp;withEmpty={withEmpty}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || pageNumber == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (pageNumber == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])pageNumber=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "pageNumber" + "}", apiInvoker.ToPathValue(pageNumber)); 
		}
        if (withEmpty == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])withEmpty=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "withEmpty" + "}", apiInvoker.ToPathValue(withEmpty)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(TextItemsResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (TextItemsResponse) ApiInvoker.deserialize(response, typeof(TextItemsResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (TextItemsResponse) ApiInvoker.deserialize(response, typeof(TextItemsResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="pageNumber"></param>
      /// <param name="fragmentNumber"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public TextFormatResponse GetFragmentTextFormat (string name, int? pageNumber, int? fragmentNumber, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/pdf/{name}/pages/{pageNumber}/fragments/{fragmentNumber}/textFormat/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || pageNumber == null || fragmentNumber == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (pageNumber == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])pageNumber=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "pageNumber" + "}", apiInvoker.ToPathValue(pageNumber)); 
		}
        if (fragmentNumber == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])fragmentNumber=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "fragmentNumber" + "}", apiInvoker.ToPathValue(fragmentNumber)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(TextFormatResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (TextFormatResponse) ApiInvoker.deserialize(response, typeof(TextFormatResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (TextFormatResponse) ApiInvoker.deserialize(response, typeof(TextFormatResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="pageNumber"></param>
      /// <param name="fragmentNumber"></param>
      /// <param name="segmentNumber"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public TextItemResponse GetSegment (string name, int? pageNumber, int? fragmentNumber, int? segmentNumber, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/pdf/{name}/pages/{pageNumber}/fragments/{fragmentNumber}/segments/{segmentNumber}/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || pageNumber == null || fragmentNumber == null || segmentNumber == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (pageNumber == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])pageNumber=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "pageNumber" + "}", apiInvoker.ToPathValue(pageNumber)); 
		}
        if (fragmentNumber == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])fragmentNumber=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "fragmentNumber" + "}", apiInvoker.ToPathValue(fragmentNumber)); 
		}
        if (segmentNumber == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])segmentNumber=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "segmentNumber" + "}", apiInvoker.ToPathValue(segmentNumber)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(TextItemResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (TextItemResponse) ApiInvoker.deserialize(response, typeof(TextItemResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (TextItemResponse) ApiInvoker.deserialize(response, typeof(TextItemResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="pageNumber"></param>
      /// <param name="fragmentNumber"></param>
      /// <param name="withEmpty"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public TextItemsResponse GetSegments (string name, int? pageNumber, int? fragmentNumber, string withEmpty, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/pdf/{name}/pages/{pageNumber}/fragments/{fragmentNumber}/segments/?appSid={appSid}&amp;withEmpty={withEmpty}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || pageNumber == null || fragmentNumber == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (pageNumber == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])pageNumber=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "pageNumber" + "}", apiInvoker.ToPathValue(pageNumber)); 
		}
        if (fragmentNumber == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])fragmentNumber=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "fragmentNumber" + "}", apiInvoker.ToPathValue(fragmentNumber)); 
		}
        if (withEmpty == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])withEmpty=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "withEmpty" + "}", apiInvoker.ToPathValue(withEmpty)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(TextItemsResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (TextItemsResponse) ApiInvoker.deserialize(response, typeof(TextItemsResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (TextItemsResponse) ApiInvoker.deserialize(response, typeof(TextItemsResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="pageNumber"></param>
      /// <param name="fragmentNumber"></param>
      /// <param name="segmentNumber"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public TextFormatResponse GetSegmentTextFormat (string name, int? pageNumber, int? fragmentNumber, int? segmentNumber, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/pdf/{name}/pages/{pageNumber}/fragments/{fragmentNumber}/segments/{segmentNumber}/textFormat/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || pageNumber == null || fragmentNumber == null || segmentNumber == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (pageNumber == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])pageNumber=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "pageNumber" + "}", apiInvoker.ToPathValue(pageNumber)); 
		}
        if (fragmentNumber == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])fragmentNumber=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "fragmentNumber" + "}", apiInvoker.ToPathValue(fragmentNumber)); 
		}
        if (segmentNumber == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])segmentNumber=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "segmentNumber" + "}", apiInvoker.ToPathValue(segmentNumber)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(TextFormatResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (TextFormatResponse) ApiInvoker.deserialize(response, typeof(TextFormatResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (TextFormatResponse) ApiInvoker.deserialize(response, typeof(TextFormatResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="pageNumber"></param>
      /// <param name="imageNumber"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public ResponseMessage GetImage (string name, int? pageNumber, int? imageNumber, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/pdf/{name}/pages/{pageNumber}/images/{imageNumber}/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || pageNumber == null || imageNumber == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (pageNumber == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])pageNumber=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "pageNumber" + "}", apiInvoker.ToPathValue(pageNumber)); 
		}
        if (imageNumber == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])imageNumber=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "imageNumber" + "}", apiInvoker.ToPathValue(imageNumber)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(ResponseMessage) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (ResponseMessage) ApiInvoker.deserialize(response, typeof(ResponseMessage));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (ResponseMessage) ApiInvoker.deserialize(response, typeof(ResponseMessage));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="pageNumber"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public ImagesResponse GetImages (string name, int? pageNumber, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/pdf/{name}/pages/{pageNumber}/images/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || pageNumber == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (pageNumber == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])pageNumber=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "pageNumber" + "}", apiInvoker.ToPathValue(pageNumber)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(ImagesResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (ImagesResponse) ApiInvoker.deserialize(response, typeof(ImagesResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (ImagesResponse) ApiInvoker.deserialize(response, typeof(ImagesResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="pageNumber"></param>
      /// <param name="imageNumber"></param>
      /// <param name="format"></param>
      /// <param name="width"></param>
      /// <param name="height"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public ResponseMessage GetImageWithFormat (string name, int? pageNumber, int? imageNumber, string format, int? width, int? height, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/pdf/{name}/pages/{pageNumber}/images/{imageNumber}/?toFormat={toFormat}&amp;appSid={appSid}&amp;width={width}&amp;height={height}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || pageNumber == null || imageNumber == null || format == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (pageNumber == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])pageNumber=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "pageNumber" + "}", apiInvoker.ToPathValue(pageNumber)); 
		}
        if (imageNumber == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])imageNumber=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "imageNumber" + "}", apiInvoker.ToPathValue(imageNumber)); 
		}
        if (format == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])format=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "format" + "}", apiInvoker.ToPathValue(format)); 
		}
        if (width == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])width=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "width" + "}", apiInvoker.ToPathValue(width)); 
		}
        if (height == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])height=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "height" + "}", apiInvoker.ToPathValue(height)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(ResponseMessage) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (ResponseMessage) ApiInvoker.deserialize(response, typeof(ResponseMessage));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (ResponseMessage) ApiInvoker.deserialize(response, typeof(ResponseMessage));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="pageNumber"></param>
      /// <param name="imageNumber"></param>
      /// <param name="imageFile"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <param name="file"></param>
      /// <returns></returns>
      public ImageResponse PostReplaceImage (string name, int? pageNumber, int? imageNumber, string imageFile, string storage, string folder, byte[] file) {
        // create path and map variables
        var ResourcePath = "/pdf/{name}/pages/{pageNumber}/images/{imageNumber}/?appSid={appSid}&amp;imageFile={imageFile}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || pageNumber == null || imageNumber == null || file == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (pageNumber == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])pageNumber=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "pageNumber" + "}", apiInvoker.ToPathValue(pageNumber)); 
		}
        if (imageNumber == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])imageNumber=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "imageNumber" + "}", apiInvoker.ToPathValue(imageNumber)); 
		}
        if (imageFile == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])imageFile=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "imageFile" + "}", apiInvoker.ToPathValue(imageFile)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        if (file != null){
         if(file is byte[]) {
		 
			 var docFile = new FileInfo();
             docFile.file = file;
             docFile.MimeType = "application/octet-stream";
             formParams.Add("file", docFile);
         } else {
           //string paramStr = (file is DateTime) ? ((DateTime)(object)file).ToString("u") : Convert.ToString(file);
		    string paramStr = Convert.ToString(file);
           formParams.Add("file", paramStr);
         }
		}
        try {
          if (typeof(ImageResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "POST", queryParams, null, headerParams, formParams);
            return (ImageResponse) ApiInvoker.deserialize(response, typeof(ImageResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, null, headerParams, formParams);
            if(response != null){
               return (ImageResponse) ApiInvoker.deserialize(response, typeof(ImageResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="pageNumber"></param>
      /// <param name="linkIndex"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public LinkAnnotationResponse GetPageLinkAnnotationByIndex (string name, int? pageNumber, int? linkIndex, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/pdf/{name}/pages/{pageNumber}/links/{linkIndex}/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || pageNumber == null || linkIndex == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (pageNumber == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])pageNumber=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "pageNumber" + "}", apiInvoker.ToPathValue(pageNumber)); 
		}
        if (linkIndex == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])linkIndex=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "linkIndex" + "}", apiInvoker.ToPathValue(linkIndex)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(LinkAnnotationResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (LinkAnnotationResponse) ApiInvoker.deserialize(response, typeof(LinkAnnotationResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (LinkAnnotationResponse) ApiInvoker.deserialize(response, typeof(LinkAnnotationResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }      
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="pageNumber"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public LinkAnnotationsResponse GetPageLinkAnnotations (string name, int? pageNumber, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/pdf/{name}/pages/{pageNumber}/links/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || pageNumber == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (pageNumber == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])pageNumber=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "pageNumber" + "}", apiInvoker.ToPathValue(pageNumber)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(LinkAnnotationsResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (LinkAnnotationsResponse) ApiInvoker.deserialize(response, typeof(LinkAnnotationsResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (LinkAnnotationsResponse) ApiInvoker.deserialize(response, typeof(LinkAnnotationsResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="pageNumber"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public SaaSposeResponse DeletePage (string name, int? pageNumber, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/pdf/{name}/pages/{pageNumber}/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || pageNumber == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (pageNumber == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])pageNumber=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "pageNumber" + "}", apiInvoker.ToPathValue(pageNumber)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(SaaSposeResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "DELETE", queryParams, null, headerParams, formParams);
            return (SaaSposeResponse) ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "DELETE", queryParams, null, headerParams, formParams);
            if(response != null){
               return (SaaSposeResponse) ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="pageNumber"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public ResponseMessage GetPage (string name, int? pageNumber, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/pdf/{name}/pages/{pageNumber}/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || pageNumber == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (pageNumber == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])pageNumber=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "pageNumber" + "}", apiInvoker.ToPathValue(pageNumber)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(ResponseMessage) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (ResponseMessage) ApiInvoker.deserialize(response, typeof(ResponseMessage));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (ResponseMessage) ApiInvoker.deserialize(response, typeof(ResponseMessage));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public DocumentPagesResponse GetPages (string name, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/pdf/{name}/pages/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(DocumentPagesResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (DocumentPagesResponse) ApiInvoker.deserialize(response, typeof(DocumentPagesResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (DocumentPagesResponse) ApiInvoker.deserialize(response, typeof(DocumentPagesResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="pageNumber"></param>
      /// <param name="format"></param>
      /// <param name="width"></param>
      /// <param name="height"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public ResponseMessage GetPageWithFormat (string name, int? pageNumber, string format, int? width, int? height, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/pdf/{name}/pages/{pageNumber}/?appSid={appSid}&amp;toFormat={toFormat}&amp;width={width}&amp;height={height}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || pageNumber == null || format == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (pageNumber == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])pageNumber=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "pageNumber" + "}", apiInvoker.ToPathValue(pageNumber)); 
		}
        if (format == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])format=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "format" + "}", apiInvoker.ToPathValue(format)); 
		}
        if (width == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])width=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "width" + "}", apiInvoker.ToPathValue(width)); 
		}
        if (height == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])height=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "height" + "}", apiInvoker.ToPathValue(height)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(ResponseMessage) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (ResponseMessage) ApiInvoker.deserialize(response, typeof(ResponseMessage));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (ResponseMessage) ApiInvoker.deserialize(response, typeof(ResponseMessage));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public WordCountResponse GetWordsPerPage (string name, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/pdf/{name}/pages/wordCount/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(WordCountResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (WordCountResponse) ApiInvoker.deserialize(response, typeof(WordCountResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (WordCountResponse) ApiInvoker.deserialize(response, typeof(WordCountResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="pageNumber"></param>
      /// <param name="newIndex"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public SaaSposeResponse PostMovePage (string name, int? pageNumber, int? newIndex, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/pdf/{name}/pages/{pageNumber}/movePage/?newIndex={newIndex}&amp;appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || pageNumber == null || newIndex == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (pageNumber == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])pageNumber=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "pageNumber" + "}", apiInvoker.ToPathValue(pageNumber)); 
		}
        if (newIndex == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])newIndex=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "newIndex" + "}", apiInvoker.ToPathValue(newIndex)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(SaaSposeResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "POST", queryParams, null, headerParams, formParams);
            return (SaaSposeResponse) ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, null, headerParams, formParams);
            if(response != null){
               return (SaaSposeResponse) ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="pageNumber"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <param name="body"></param>
      /// <returns></returns>
      public SaaSposeResponse PostSignPage (string name, int? pageNumber, string storage, string folder, Signature body) {
        // create path and map variables
        var ResourcePath = "/pdf/{name}/pages/{pageNumber}/sign/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || pageNumber == null || body == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (pageNumber == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])pageNumber=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "pageNumber" + "}", apiInvoker.ToPathValue(pageNumber)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(SaaSposeResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "POST", queryParams, null, headerParams, formParams);
            return (SaaSposeResponse) ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, body, headerParams, formParams);
            if(response != null){
               return (SaaSposeResponse) ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public DocumentPagesResponse PutAddNewPage (string name, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/pdf/{name}/pages/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(DocumentPagesResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "PUT", queryParams, null, headerParams, formParams);
            return (DocumentPagesResponse) ApiInvoker.deserialize(response, typeof(DocumentPagesResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "PUT", queryParams, null, headerParams, formParams);
            if(response != null){
               return (DocumentPagesResponse) ApiInvoker.deserialize(response, typeof(DocumentPagesResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="pageNumber"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <param name="body"></param>
      /// <returns></returns>
      public SaaSposeResponse PutPageAddStamp (string name, int? pageNumber, string storage, string folder, Stamp body) {
        // create path and map variables
        var ResourcePath = "/pdf/{name}/pages/{pageNumber}/stamp/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || pageNumber == null || body == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (pageNumber == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])pageNumber=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "pageNumber" + "}", apiInvoker.ToPathValue(pageNumber)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(SaaSposeResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "PUT", queryParams, null, headerParams, formParams);
            return (SaaSposeResponse) ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "PUT", queryParams, body, headerParams, formParams);
            if(response != null){
               return (SaaSposeResponse) ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public SaaSposeResponse DeleteProperties (string name, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/pdf/{name}/documentproperties/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(SaaSposeResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "DELETE", queryParams, null, headerParams, formParams);
            return (SaaSposeResponse) ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "DELETE", queryParams, null, headerParams, formParams);
            if(response != null){
               return (SaaSposeResponse) ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="propertyName"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public SaaSposeResponse DeleteProperty (string name, string propertyName, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/pdf/{name}/documentproperties/{propertyName}/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || propertyName == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (propertyName == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])propertyName=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "propertyName" + "}", apiInvoker.ToPathValue(propertyName)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(SaaSposeResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "DELETE", queryParams, null, headerParams, formParams);
            return (SaaSposeResponse) ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "DELETE", queryParams, null, headerParams, formParams);
            if(response != null){
               return (SaaSposeResponse) ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public DocumentPropertiesResponse GetDocumentProperties (string name, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/pdf/{name}/documentproperties/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(DocumentPropertiesResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (DocumentPropertiesResponse) ApiInvoker.deserialize(response, typeof(DocumentPropertiesResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (DocumentPropertiesResponse) ApiInvoker.deserialize(response, typeof(DocumentPropertiesResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="propertyName"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public DocumentPropertyResponse GetDocumentProperty (string name, string propertyName, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/pdf/{name}/documentproperties/{propertyName}/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || propertyName == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (propertyName == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])propertyName=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "propertyName" + "}", apiInvoker.ToPathValue(propertyName)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(DocumentPropertyResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (DocumentPropertyResponse) ApiInvoker.deserialize(response, typeof(DocumentPropertyResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (DocumentPropertyResponse) ApiInvoker.deserialize(response, typeof(DocumentPropertyResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="propertyName"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <param name="body"></param>
      /// <returns></returns>
      public DocumentPropertyResponse PutSetProperty (string name, string propertyName, string storage, string folder, DocumentProperty body) {
        // create path and map variables
        var ResourcePath = "/pdf/{name}/documentproperties/{propertyName}/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || propertyName == null || body == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (propertyName == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])propertyName=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "propertyName" + "}", apiInvoker.ToPathValue(propertyName)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(DocumentPropertyResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "PUT", queryParams, null, headerParams, formParams);
            return (DocumentPropertyResponse) ApiInvoker.deserialize(response, typeof(DocumentPropertyResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "PUT", queryParams, body, headerParams, formParams);
            if(response != null){
               return (DocumentPropertyResponse) ApiInvoker.deserialize(response, typeof(DocumentPropertyResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="pageNumber"></param>
      /// <param name="withEmpty"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public TextItemsResponse GetPageTextItems (string name, int? pageNumber, string withEmpty, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/pdf/{name}/pages/{pageNumber}/textItems/?appSid={appSid}&amp;withEmpty={withEmpty}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || pageNumber == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (pageNumber == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])pageNumber=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "pageNumber" + "}", apiInvoker.ToPathValue(pageNumber)); 
		}
        if (withEmpty == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])withEmpty=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "withEmpty" + "}", apiInvoker.ToPathValue(withEmpty)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(TextItemsResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (TextItemsResponse) ApiInvoker.deserialize(response, typeof(TextItemsResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (TextItemsResponse) ApiInvoker.deserialize(response, typeof(TextItemsResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="withEmpty"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public TextItemsResponse GetTextItems (string name, string withEmpty, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/pdf/{name}/textItems/?appSid={appSid}&amp;withEmpty={withEmpty}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (withEmpty == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])withEmpty=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "withEmpty" + "}", apiInvoker.ToPathValue(withEmpty)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(TextItemsResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (TextItemsResponse) ApiInvoker.deserialize(response, typeof(TextItemsResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (TextItemsResponse) ApiInvoker.deserialize(response, typeof(TextItemsResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <param name="body"></param>
      /// <returns></returns>
      public DocumentTextReplaceResponse PostDocumentReplaceText (string name, string storage, string folder, TextReplace body) {
        // create path and map variables
        var ResourcePath = "/pdf/{name}/replaceText/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || body == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(DocumentTextReplaceResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "POST", queryParams, null, headerParams, formParams);
            return (DocumentTextReplaceResponse) ApiInvoker.deserialize(response, typeof(DocumentTextReplaceResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, body, headerParams, formParams);
            if(response != null){
               return (DocumentTextReplaceResponse) ApiInvoker.deserialize(response, typeof(DocumentTextReplaceResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <param name="body"></param>
      /// <returns></returns>
      public DocumentTextReplaceResponse PostDocumentReplaceTextList (string name, string storage, string folder, TextReplaceListRequest body) {
        // create path and map variables
        var ResourcePath = "/pdf/{name}/replaceTextList/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || body == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(DocumentTextReplaceResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "POST", queryParams, null, headerParams, formParams);
            return (DocumentTextReplaceResponse) ApiInvoker.deserialize(response, typeof(DocumentTextReplaceResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, body, headerParams, formParams);
            if(response != null){
               return (DocumentTextReplaceResponse) ApiInvoker.deserialize(response, typeof(DocumentTextReplaceResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="pageNumber"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <param name="body"></param>
      /// <returns></returns>
      public PageTextReplaceResponse PostPageReplaceText (string name, int? pageNumber, string storage, string folder, TextReplace body) {
        // create path and map variables
        var ResourcePath = "/pdf/{name}/pages/{pageNumber}/replaceText/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || pageNumber == null || body == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (pageNumber == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])pageNumber=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "pageNumber" + "}", apiInvoker.ToPathValue(pageNumber)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(PageTextReplaceResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "POST", queryParams, null, headerParams, formParams);
            return (PageTextReplaceResponse) ApiInvoker.deserialize(response, typeof(PageTextReplaceResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, body, headerParams, formParams);
            if(response != null){
               return (PageTextReplaceResponse) ApiInvoker.deserialize(response, typeof(PageTextReplaceResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="pageNumber"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <param name="body"></param>
      /// <returns></returns>
      public PageTextReplaceResponse PostPageReplaceTextList (string name, int? pageNumber, string storage, string folder, TextReplaceListRequest body) {
        // create path and map variables
        var ResourcePath = "/pdf/{name}/pages/{pageNumber}/replaceTextList/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || pageNumber == null || body == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (pageNumber == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])pageNumber=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "pageNumber" + "}", apiInvoker.ToPathValue(pageNumber)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(PageTextReplaceResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "POST", queryParams, null, headerParams, formParams);
            return (PageTextReplaceResponse) ApiInvoker.deserialize(response, typeof(PageTextReplaceResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, body, headerParams, formParams);
            if(response != null){
               return (PageTextReplaceResponse) ApiInvoker.deserialize(response, typeof(PageTextReplaceResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      }
    }
