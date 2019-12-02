﻿/*using Bot3PG.Modules.General;
using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System.Threading.Tasks;

namespace Bot3PG.Modules.Music
{
    [Color(45, 25, 25)]
    public sealed class Music : CommandBase
    {
        public AudioService AudioService { get; set; }

        [Command("Join")]
        [Summary("Get bot to join your voice channel")]
        [RequireUserPermission(GuildPermission.Connect)]
        [RequireBotPermission(GuildPermission.Connect)]
        public async Task JoinAndPlay() => await ReplyAsync(await AudioService.JoinOrPlayAsync((SocketGuildUser)Context.User, Context.Channel as SocketTextChannel, Context.Guild.Id));

        [Command("Leave")]
        [Summary("Get bot to leave your voice channel")]
        [RequireUserPermission(GuildPermission.Connect)]
        [RequireBotPermission(GuildPermission.Connect)]
        public async Task Leave() => await ReplyAsync(await AudioService.LeaveAsync(Context.Guild.Id));

        [Command("Play"), Alias("YouTube")]
        [Summary("Search YouTube for tracks to play")]
        [RequireUserPermission(GuildPermission.Speak)]
        [RequireBotPermission(GuildPermission.Speak), RequireBotPermission(GuildPermission.Connect)]
        public async Task Play([Remainder]string query) => await ReplyAsync(await AudioService.JoinOrPlayAsync((SocketGuildUser)Context.User, Context.Channel as SocketTextChannel, Context.Guild.Id, query));

        [Command("SoundCloud")]
        [Summary("Search SoundCloud for tracks to play")]
        [RequireUserPermission(GuildPermission.Speak)]
        [RequireBotPermission(GuildPermission.Speak)]
        public async Task PlaySoundcloud([Remainder]string search) => await ReplyAsync(await AudioService.JoinOrPlayAsync((SocketGuildUser)Context.User, Context.Channel as SocketTextChannel, Context.Guild.Id, search, "soundcloud"));

        [Command("Stop")]
        [Summary("Stop all music playback")]
        [RequireUserPermission(GuildPermission.Speak)]
        [RequireBotPermission(GuildPermission.Speak)]
        public async Task Stop() => await ReplyAsync(await AudioService.StopAsync(Context.Guild.Id));

        [Command("Queue"), Alias("List")]
        [Summary("Display currently playing or listed tracks")]
        public async Task Queue() => await ReplyAsync(await AudioService.ListAsync(Context.Guild.Id));

        [Command("Skip"), Alias("S")]
        [Summary("Play next song in queue")]
        [RequireUserPermission(GuildPermission.Speak)]
        public async Task Skip() => await ReplyAsync(await AudioService.SkipTrackAsync(Context.Guild.Id));

        [Command("Volume")]
        [Summary("Manage the volume of bot music")]
        [RequireUserPermission(GuildPermission.Speak)]
        public async Task Volume(int value = 0) => await ReplyAsync(await AudioService.VolumeAsync(Context.Guild.Id, value));

        [Command("Pause")]
        [Summary("Pause playback, if playing")]
        [RequireUserPermission(GuildPermission.Speak)]
        public async Task Pause() => await ReplyAsync(await AudioService.PauseOrResume(Context.Guild.Id));

        [Command("Resume")]
        [Summary("Resume playback, if paused")]
        [RequireUserPermission(GuildPermission.Speak)]
        public async Task Resume() => await ReplyAsync(await AudioService.PauseOrResume(Context.Guild.Id));
    }
}*/