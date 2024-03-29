﻿using Newtonsoft.Json;

namespace Sendeo.Client.Models.Request;

/// <summary>
/// Gönderi durumu hakkında bilgi alınan uç noktaya gönderilecek istek nesnesidir.
/// </summary>
public class TrackDeliveryRequest
{
	/// <summary>
	/// Gönderi takip numarası.
	/// </summary>
	/// <remarks> Gönderi takip numarası veya gönderi müşteri referans numarasından en az birisi istekte belirtilmelidir. </remarks>
	[JsonProperty("trackingNo")]
	public long? TrackingNo { get; set; }

	/// <summary>
	/// Gönderi müşteri referans numarası.
	/// </summary>
	/// <remarks> Gönderi takip numarası veya gönderi müşteri referans numarasından en az birisi istekte belirtilmelidir. </remarks>
	[JsonProperty("referenceNo")]
	public string? ReferenceNo { get; set; }
}