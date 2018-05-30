// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Vision.Face
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for FaceListOperations.
    /// </summary>
    public static partial class FaceListOperationsExtensions
    {
            /// <summary>
            /// Create an empty face list. Up to 64 face lists are allowed to exist in one
            /// subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='faceListId'>
            /// Id referencing a particular face list.
            /// </param>
            /// <param name='name'>
            /// User defined name, maximum length is 128.
            /// </param>
            /// <param name='userData'>
            /// User specified data. Length should not exceed 16KB.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task CreateAsync(this IFaceListOperations operations, string faceListId, string name = default(string), string userData = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.CreateWithHttpMessagesAsync(faceListId, name, userData, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Retrieve a face list's information.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='faceListId'>
            /// Id referencing a particular face list.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<FaceList> GetAsync(this IFaceListOperations operations, string faceListId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(faceListId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update information of a face list.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='faceListId'>
            /// Id referencing a particular face list.
            /// </param>
            /// <param name='name'>
            /// User defined name, maximum length is 128.
            /// </param>
            /// <param name='userData'>
            /// User specified data. Length should not exceed 16KB.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UpdateAsync(this IFaceListOperations operations, string faceListId, string name = default(string), string userData = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.UpdateWithHttpMessagesAsync(faceListId, name, userData, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Delete an existing face list according to faceListId. Persisted face images
            /// in the face list will also be deleted.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='faceListId'>
            /// Id referencing a particular face list.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IFaceListOperations operations, string faceListId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(faceListId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Retrieve information about all existing face lists. Only faceListId, name
            /// and userData will be returned.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<FaceList>> ListAsync(this IFaceListOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete an existing face from a face list (given by a persisitedFaceId and a
            /// faceListId). Persisted image related to the face will also be deleted.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='faceListId'>
            /// Id referencing a particular face list.
            /// </param>
            /// <param name='persistedFaceId'>
            /// Id referencing a particular persistedFaceId of an existing face.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteFaceAsync(this IFaceListOperations operations, string faceListId, System.Guid persistedFaceId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteFaceWithHttpMessagesAsync(faceListId, persistedFaceId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Add a face to a face list. The input face is specified as an image with a
            /// targetFace rectangle. It returns a persistedFaceId representing the added
            /// face, and persistedFaceId will not expire.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='faceListId'>
            /// Id referencing a particular face list.
            /// </param>
            /// <param name='url'>
            /// </param>
            /// <param name='userData'>
            /// User-specified data about the face for any purpose. The maximum length is
            /// 1KB.
            /// </param>
            /// <param name='targetFace'>
            /// A face rectangle to specify the target face to be added to a person in the
            /// format of "targetFace=left,top,width,height". E.g.
            /// "targetFace=10,10,100,100". If there is more than one face in the image,
            /// targetFace is required to specify which face to add. No targetFace means
            /// there is only one face detected in the entire image.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PersistedFace> AddFaceFromUrlAsync(this IFaceListOperations operations, string faceListId, string url, string userData = default(string), IList<int> targetFace = default(IList<int>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.AddFaceFromUrlWithHttpMessagesAsync(faceListId, url, userData, targetFace, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Add a face to a face list. The input face is specified as an image with a
            /// targetFace rectangle. It returns a persistedFaceId representing the added
            /// face, and persistedFaceId will not expire.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='faceListId'>
            /// Id referencing a particular face list.
            /// </param>
            /// <param name='image'>
            /// An image stream.
            /// </param>
            /// <param name='userData'>
            /// User-specified data about the face for any purpose. The maximum length is
            /// 1KB.
            /// </param>
            /// <param name='targetFace'>
            /// A face rectangle to specify the target face to be added to a person in the
            /// format of "targetFace=left,top,width,height". E.g.
            /// "targetFace=10,10,100,100". If there is more than one face in the image,
            /// targetFace is required to specify which face to add. No targetFace means
            /// there is only one face detected in the entire image.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PersistedFace> AddFaceFromStreamAsync(this IFaceListOperations operations, string faceListId, Stream image, string userData = default(string), IList<int> targetFace = default(IList<int>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.AddFaceFromStreamWithHttpMessagesAsync(faceListId, image, userData, targetFace, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
